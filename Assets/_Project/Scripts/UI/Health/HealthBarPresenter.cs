using System;
using Atomic.Elements;
using Atomic.Entities;
using GameCycle;
using JetBrains.Annotations;
using Zenject;

namespace UI
{
    [UsedImplicitly]
    public sealed class HealthBarPresenter : IInitializable, IGameFinish
    {
        private readonly IEntity _character;
        private readonly HealthBarView _view;
        private IReactiveValue<float> _health;
        private IReactiveValue<int> _maxValue;
        
        public HealthBarPresenter(IEntity character, HealthBarView view)
        {
            _view = view;
            _character = character;
        }

        void IInitializable.Initialize()
        {
            _health = _character.GetHealth();
            _maxValue = _character.GetMaxHealth();
            
            _health.Subscribe(OnHealthChanged);
            _maxValue.Subscribe(OnMaHealthChanged);
            UpdateHealth();
        }
        
        private void OnHealthChanged(float health)
        {
            UpdateHealth();
        }

        private void OnMaHealthChanged(int maxHealth)
        {
            UpdateHealth();
        }

        private void UpdateHealth()
        {
            var amount = _health.Value / _maxValue.Value;
            _view.UpdateProgress(amount);
            _view.SetHealth($"{Math.Round(amount * 100, 1)}%");
        }

        public void OnFinish()
        {
            _health.Unsubscribe(OnHealthChanged);
            _maxValue.Unsubscribe(OnMaHealthChanged);
        }
    }
}