using JetBrains.Annotations;
using UnityEngine;
using Zenject;

namespace GamePlay
{
    [UsedImplicitly]
    public class CursorSystem : IInitializable
    {
        public void Initialize()
        {
            DisableCursor();
        }

        public void DisableCursor()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        public void EnableCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}