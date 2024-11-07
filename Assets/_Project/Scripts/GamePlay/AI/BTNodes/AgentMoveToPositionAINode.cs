using System;
using Atomic.AI;
using Unity.Mathematics;

namespace GamePlay
{
    [Serializable]
    public sealed class AgentMoveToPositionAINode : BTNode
    {
        public override string Name => "Move To Position";
        
        protected override BTResult OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            if (!blackboard.TryGetAgent(out var agent))
                return BTResult.FAILURE;

            return !agent.pathPending && agent.remainingDistance <= agent.stoppingDistance
                ? BTResult.SUCCESS
                : BTResult.RUNNING;
        }

        protected override void OnEnable(IBlackboard blackboard)
        {
            if (blackboard.TryGetMovePosition(out float3 targetPosition))
            {
                var agent = blackboard.GetAgent();
                agent.stoppingDistance = 1;
                agent.SetDestination(targetPosition);
            }
        }

        protected override void OnDisable(IBlackboard blackboard)
        {
            if (blackboard.TryGetAgent(out var agent)) 
                agent.destination = agent.destination;
        }
    }
}