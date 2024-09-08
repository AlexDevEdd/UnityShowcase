using Cysharp.Threading.Tasks;
using GameCycle;
using JetBrains.Annotations;

namespace App
{
    [UsedImplicitly]
    public sealed class StartGameCycleAppStep : AppStepBase
    {
        private readonly GameCycleSystem _gameCycleSystem;
        private const int ID  = 4;
        
        public StartGameCycleAppStep(GameCycleSystem gameCycleSystem, AppStepConfiguration stepConfiguration)
        {
            _gameCycleSystem = gameCycleSystem;
            var config = stepConfiguration.GetConfig(ID);
            Id = ID;
            Title = config.TitleText;
            Duration = config.Duration; 
        }
        
        public override async UniTask WaitOnCompleted()
        {
            _gameCycleSystem.OnStartEvent();
            await UniTask.Delay((int)(Duration * 1000));
        }
    }
}