using System;
using Atomic.AI;

namespace GamePlay
{
    [Serializable]
    public sealed class DisableAIBlackboardAction : IBlackboardAction
    {
        public SceneBehaviourTree _sceneBehaviourTree;
        public SceneBehaviourGroup _sceneBehaviourGroup;
        
        public void Invoke(IBlackboard blackboard)
        {
            _sceneBehaviourTree.enabled = false;
            _sceneBehaviourGroup.enabled = false;
            blackboard.GetSelf().Disable();
            blackboard.GetAgent().enabled = false;
        }
    }
}