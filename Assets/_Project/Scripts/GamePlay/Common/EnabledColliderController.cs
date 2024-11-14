using JetBrains.Annotations;
using UnityEngine;

namespace GamePlay
{
    public class EnabledColliderController : MonoBehaviour
    {
        [SerializeField]
        private Collider _collider;

        [UsedImplicitly]
        public void Enable()
        {
            _collider.enabled = true;
        }
        
        [UsedImplicitly]
        public void Disable()
        {
            _collider.enabled = false;
        }
    }
}