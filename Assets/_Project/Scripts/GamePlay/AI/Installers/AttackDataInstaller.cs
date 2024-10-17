using System;
using Atomic.AI;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GamePlay
{
    [Serializable, InlineProperty]
    public sealed class AttackDataInstaller : IBlackboardInstaller
    {
        [HorizontalGroup]
        [BlackboardKey]
        [SerializeField, HideLabel]
        private int _key = BlackboardAPI.AttackData;
        
        [HorizontalGroup]
        [SerializeField]
        private AttackData _attackData;
        
        public void Install(IBlackboard blackboard)
        {
            blackboard.SetStruct(_key, _attackData);
        }
    }
}