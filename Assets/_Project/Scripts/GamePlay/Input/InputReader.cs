using System;
using GameCycle;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GamePlay
{
    [UsedImplicitly]
    public class InputReader : PlayerControls.ICharacterActions , IGameStart, IInput
    {
        public event Action<Vector2> OnMoveEvent;
        public event Action<bool> OnRunEvent;
        public event Action<Vector2> OnAimEvent;
        public event Action OnFireEvent;
        
        public event Action<int> OnWeaponChanged;

        private readonly PlayerControls _input = new ();


        public void OnStart()
        {
            EnableInput();
        }

        public void EnableInput()
        {
            _input.Character.Enable();
            _input.Character.SetCallbacks(this);
        }

        public void DisableInput()
        {
            _input.Character.Disable();
        }

        public void OnFire(InputAction.CallbackContext context)
        {
            switch (context.phase)
            {
                case InputActionPhase.Performed:
                    OnFireEvent?.Invoke();
                    break;
            }
           
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            switch (context.phase)
            {
                case InputActionPhase.Performed:
                    OnMoveEvent?.Invoke(context.ReadValue<Vector2>());
                    break;
                case InputActionPhase.Canceled:
                    OnMoveEvent?.Invoke(Vector2.zero);
                    break;
            }
           
        }

        public void OnAim(InputAction.CallbackContext context)
        {
            switch (context.phase)
            {
                case InputActionPhase.Performed:
                    OnAimEvent?.Invoke(context.ReadValue<Vector2>());
                    break;
                case InputActionPhase.Canceled:
                    OnAimEvent?.Invoke(Vector2.zero);
                    break;
            }
        }

        public void OnRun(InputAction.CallbackContext context)
        {
            switch (context.phase)
            {
                case InputActionPhase.Performed:
                    OnRunEvent?.Invoke(true);
                    break;
                case InputActionPhase.Canceled:
                    OnRunEvent?.Invoke(false);
                    break;
            }
        }

        public void OnKeybord_1(InputAction.CallbackContext context)
        {
            OnWeaponChanged?.Invoke(1);
        }

        public void OnKeybord_2(InputAction.CallbackContext context)
        {
            OnWeaponChanged?.Invoke(2);
        }

        public void OnKeybord_3(InputAction.CallbackContext context)
        {
            OnWeaponChanged?.Invoke(3);
        }

        public void OnKeybord_4(InputAction.CallbackContext context)
        {
            OnWeaponChanged?.Invoke(4);
        }
    }
}