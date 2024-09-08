using Cysharp.Threading.Tasks;
using JetBrains.Annotations;

namespace App
{
    [UsedImplicitly]
    public sealed class Test_SecondAppStep : AppStepBase
    {
        private const int ID  = 2;
        
        public Test_SecondAppStep(AppStepConfiguration stepConfiguration)
        {
            var config = stepConfiguration.GetConfig(ID);
            Id = ID;
            Title = config.TitleText;
            Duration = config.Duration; 
        }
        
        public override async UniTask WaitOnCompleted()
        {
            await UniTask.Delay((int)(Duration * 1000));
        }
    }
}