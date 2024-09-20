using System;
using UnityEngine;

namespace GamePlay
{
    public sealed class CollisionObserver : MonoBehaviour
    {
        public event Action<Collider> OnEnter;
        public event Action<Collider> OnExit;
        private void OnTriggerEnter(Collider other)
        {
            OnEnter?.Invoke(other);
        }
        
        private void OnTriggerExit(Collider other)
        {
            OnExit?.Invoke(other);
        }
    }
}