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
        public event Action<Vector2> OnAimEvent;
        public event Action OnFireEvent;

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
    }
}