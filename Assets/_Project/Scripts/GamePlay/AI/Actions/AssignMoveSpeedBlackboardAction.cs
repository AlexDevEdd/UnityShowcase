using System;
using Atomic.AI;
using Atomic.Entities;
using UnityEngine;

namespace GamePlay
{
    [Serializable]
    public sealed class AssignMoveSpeedBlackboardAction : IBlackboardAction
    {
        [SerializeField]
        private float _moveSpeed;
        
        public void Invoke(IBlackboard blackboard)
        {
            var entity = blackboard.GetSelf();
            var moveSpeed = entity.GetMoveSpeed();
            
            if(Mathf.Approximately(moveSpeed.Value, _moveSpeed))
                return;
            
            moveSpeed.Value = _moveSpeed;
            blackboard.GetAgent().speed = _moveSpeed;
        }
    }
}