using System;
using UnityEngine;

namespace GamePlay
{
    public sealed class CollisionObserver : MonoBehaviour
    {
        public event Action<Collision> OnEnter;
        public event Action<Collision> OnExit;

        private void OnCollisionEnter(Collision other)
        {
            Debug.Log($"{other.gameObject.name}");
            OnEnter?.Invoke(other);
        }

        private void OnCollisionExit(Collision other)
        {
            OnExit?.Invoke(other);
        }
    }
}