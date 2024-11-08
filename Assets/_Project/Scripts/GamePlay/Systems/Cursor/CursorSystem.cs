using AssetManagement;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Zenject;

namespace GamePlay
{
    [UsedImplicitly]
    public class CursorSystem : IInitializable, ITickable
    {
        private readonly IAssetProvider _assetProvider;

        private Texture2D _fire;
        private Texture2D _ui;
        
        public CursorSystem(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }
        public async void Initialize()
        {
            await LoadCursorTexturesAsync();
            SetUpFireCursor();
        }

        private async UniTask LoadCursorTexturesAsync()
        {
           _fire = await _assetProvider.LoadAsync<Texture2D>(AssetKeys.CURSOR_FIRE);
           _ui = await _assetProvider.LoadAsync<Texture2D>(AssetKeys.CURSOR_UI);
        } 

        public void SetUpFireCursor()
        {
            //Cursor.SetCursor(_fire, Vector2.zero, CursorMode.Auto);
            Cursor.visible = false;
        }
        
        public void SetUpUiCursor()
        {
            //Cursor.SetCursor(_ui, Vector2.zero, CursorMode.Auto);
            Cursor.visible = true;
        }

        public void Tick()
        {
            if (Input.GetKey(KeyCode.Keypad1))
            {
                SetUpFireCursor();
            }

            if (Input.GetKey(KeyCode.Keypad2))
            {
                SetUpUiCursor();
            }
            
            if (Input.GetKey(KeyCode.Keypad8))
            {
                if(Mathf.Approximately(Time.timeScale, 0.2f)) return;
                Time.timeScale -= 0.2f;
            }
            
            if (Input.GetKey(KeyCode.Keypad9))
            {
                Time.timeScale += 0.2f;
            }
            
            if (Input.GetKey(KeyCode.Keypad7))
            {
                Time.timeScale = 1;
            }
        }
    }
}