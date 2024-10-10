using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Debug
{
    public sealed class TestMono : MonoBehaviour
    {
        private IEntity _character;
        private IVariable<float> _health;
        private IVariable<int> _maxValue;
        
        [Inject]
        private void Construct(IEntity character)
        {
            _character = character;
        }
        
        private void Start()
        {
            _health = _character.GetHealth();
            _maxValue = _character.GetMaxHealth();
        }

        [Button]
        private void AddHealth(float value)
        {
            _health.Value += value;
        }

        [Button]
        private void RemoveHealth(float value)
        {
            _health.Value -= value;
        }

        [Button]
        private void AddMaxHealth(int value)
        {
            _maxValue.Value += value;
        }
    }
}