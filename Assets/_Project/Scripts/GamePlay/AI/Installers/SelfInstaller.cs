using System;
using Atomic.AI;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GamePlay
{
    [Serializable, InlineProperty]
    public sealed class SelfInstaller : IBlackboardInstaller
    {
        [HorizontalGroup]
        [SerializeField]
        private SceneEntity _entity;
        
        public void Install(IBlackboard blackboard)
        {
            blackboard.SetSelf(_entity);
        }
    }
}