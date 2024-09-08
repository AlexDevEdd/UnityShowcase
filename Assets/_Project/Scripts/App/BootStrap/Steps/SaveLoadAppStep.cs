using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using SaveLoad;

namespace App
{
    [UsedImplicitly]
    public sealed class SaveLoadAppStep : AppStepBase, IDisposable
    {
        private readonly ISaveSystem _saveSystem;
        private const int ID  = 3;

        private CancellationTokenSource _tokenSource;
        
        public SaveLoadAppStep(ISaveSystem saveSystem, AppStepConfiguration stepConfiguration)
        {
            _saveSystem = saveSystem;
            var config = stepConfiguration.GetConfig(ID);
            Id = ID;
            Title = config.TitleText;
            Duration = config.Duration; 
        }
        
        public override async UniTask WaitOnCompleted()
        {
            _tokenSource = new CancellationTokenSource();
            
            var taskList = new List<UniTask>
            {
                UniTask.Delay((int)(Duration * 1000)),
                _saveSystem.LoadAsync(),
            };
            
            await UniTask.WhenAll(taskList).AttachExternalCancellation(_tokenSource.Token);
        }

        public void Dispose()
        {
            _tokenSource?.Cancel();
            _tokenSource?.Dispose();
        }
    }
}