using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Zenject;

namespace MobileJoystick
{
    [UsedImplicitly]
    public sealed class JoystickController : IInitializable, IDisposable
    {
        public event Action OnStop;
        public event Action OnMove;
    
        private readonly FloatingJoystick _joystick;
        private Finger _movementFinger;
        
        public Vector2 Amount { get; private set; }
        
        public JoystickController(FloatingJoystick joystick)
        {
            _joystick = joystick;
        }
    
        void IInitializable.Initialize()
        {
            OnEnable();
        }

        void IDisposable.Dispose()
        {
            OnDisable();
        }
    
        public void OnEnable()
        {
            EnhancedTouchSupport.Enable();
            UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerDown += HandleFingerDown;
            UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerUp += HandleLoseFinger;
            UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerMove += HandleFingerMove;
            _joystick?.Show();
        }
    
        public void OnDisable()
        {
            if (_joystick is not null)
                Stop();
            
            UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerDown -= HandleFingerDown;
            UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerUp -= HandleLoseFinger;
            UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerMove -= HandleFingerMove;
            EnhancedTouchSupport.Disable();
            _movementFinger = null;
            Amount = Vector2.zero;
        }
    
        private void HandleFingerMove(Finger movedFinger)
        {
            if (movedFinger == _movementFinger)
            {
                Vector2 knobPosition;
                var maxMovement = _joystick.JoystickSize.x / 2f;
                var currentTouch = movedFinger.currentTouch;

                if (Vector2.Distance(currentTouch.screenPosition, _joystick.RectTransform.anchoredPosition) > maxMovement)
                {
                    knobPosition = (currentTouch.screenPosition - _joystick.RectTransform.anchoredPosition).normalized * maxMovement;
                }
                else
                {
                    knobPosition = currentTouch.screenPosition - _joystick.RectTransform.anchoredPosition;
                }

                _joystick.Knob.anchoredPosition = knobPosition;
                Amount = knobPosition / maxMovement;
            }
        
            OnMove?.Invoke();
        }
    
        private void HandleLoseFinger(Finger lostFinger)
        {
            if (lostFinger == _movementFinger)
            {
                Stop();
            }
        }

        private void HandleFingerDown(Finger touchedFinger)
        {
            if (_movementFinger == null)
            {
                _movementFinger = touchedFinger;
                Amount = Vector2.zero;
            
                _joystick.Show();
                _joystick.RectTransform.sizeDelta = _joystick.JoystickSize;
                _joystick.RectTransform.anchoredPosition = ClampStartPosition(touchedFinger.screenPosition);
            }
        }

        private Vector2 ClampStartPosition(Vector2 startPosition)
        {
            if (startPosition.x < _joystick.JoystickSize.x / 2)
            {
                startPosition.x = _joystick.JoystickSize.x / 2;
            }

            if (startPosition.y < _joystick.JoystickSize.y / 2)
            {
                startPosition.y = _joystick.JoystickSize.y / 2;
            }
            else if (startPosition.y > Screen.height - _joystick.JoystickSize.y / 2)
            {
                startPosition.y = Screen.height - _joystick.JoystickSize.y / 2;
            }

            return startPosition;
        }

        private void Stop()
        {
            _movementFinger = null;
            _joystick.Knob.anchoredPosition = Vector2.zero;
            _joystick.Hide();
            Amount = Vector2.zero;
            OnStop?.Invoke();
        }
    }
}