using UnityEngine;

namespace GamePlay
{
    public sealed class WorldSpaceContainer : MonoBehaviour
    {
        [SerializeField]
        private Canvas _canvas;
        
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        public void SetUpCanvasCamera()
        {
            _canvas.worldCamera = Camera.main;
        }
    }
}