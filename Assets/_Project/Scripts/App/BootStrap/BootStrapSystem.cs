using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using Zenject;

namespace App
{
    [UsedImplicitly]
    public class BootStrapSystem : IInitializable
    {
        private readonly LoadingWindow _loadingWindow;
        private readonly List<IAppStep> _steps;

        public BootStrapSystem(LoadingWindow loadingWindow, IEnumerable<IAppStep> steps)
        {
            _loadingWindow = loadingWindow;
            _steps = steps.OrderBy(s => s.Id).ToList();
        }

        public void Initialize()
        {
            StartAllStep().Forget();
        }
        
        private async UniTaskVoid StartAllStep()
        {
            var countStep = _steps.Count;
            
            _loadingWindow.Show();
            
            for (var index = 0; index < countStep; index++)
            {
                var step = _steps[index];
                _loadingWindow.SetTitle(step.Title);

                if (index != countStep - 1)
                { 
                    _loadingWindow.StartProgress(1, step.Duration);
                }
                
                await step.WaitOnCompleted();
                
            }
            _loadingWindow.Hide();
        }
    }
}