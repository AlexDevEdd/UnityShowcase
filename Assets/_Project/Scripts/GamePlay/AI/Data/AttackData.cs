using System;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public struct AttackData
    {
        [field: SerializeField] 
        public bool IsEnabled { get; private set; }
       
        [field: SerializeField] 
        public float MinDistance { get; private set; }
        
        public float MinDistanceSqr => MinDistance * MinDistance;

        public void SetEnabled(bool isEnabled)
        {
            IsEnabled = isEnabled;
        }

        public void SetMinDistance(float value)
        {
            MinDistance = value;
        }
    }
}