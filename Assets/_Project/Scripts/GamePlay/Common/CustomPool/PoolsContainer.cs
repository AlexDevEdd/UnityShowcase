using UnityEngine;

namespace GamePlay
{
    public sealed class PoolsContainer : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}