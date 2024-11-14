using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;

namespace GamePlay
{
    [UsedImplicitly]
    public class InputDisabler : IGameStart, IGameFinish
    {
        private readonly IEntity _entity;
        private readonly IEnabledInput _enabledInput;

        private EventAction<IEntity> _dieAction;

        public InputDisabler(IEntity entity, IEnabledInput enabledInput)
        {
            _entity = entity;
            _enabledInput = enabledInput;
        }
        
        public void OnStart()
        {
            _dieAction = _entity.GetDieAction();
            _dieAction.Subscribe(OnDisableInput);
        }

        private void OnDisableInput(IEntity entity)
        {
            _enabledInput.DisableInput();
            _entity.Dispose();
        }
        
        public void OnFinish()
        {
            _dieAction.Unsubscribe(OnDisableInput);
        }
    }
}