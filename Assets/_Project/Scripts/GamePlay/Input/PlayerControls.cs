//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Project/Settings/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GamePlay
{
    public partial class @PlayerControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""34acfceb-d7b7-418b-852f-4058dd265c37"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""126ebe3b-2e8a-483c-a674-fbed397d1f95"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a743f4a3-adf0-499d-a6a4-603b924eca34"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""242d7eea-1c5d-4254-8143-81e7c45ff49d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""e015213f-440c-467a-9df7-8f907516beba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Keybord_1"",
                    ""type"": ""Button"",
                    ""id"": ""d0e8b471-5a44-4278-8fcc-cffadef30eda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Keybord_2"",
                    ""type"": ""Button"",
                    ""id"": ""41cace0b-66dc-44b2-b05c-c013201de316"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Keybord_3"",
                    ""type"": ""Button"",
                    ""id"": ""01a60894-b79a-4055-83c4-0db5494a72f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Keybord_4"",
                    ""type"": ""Button"",
                    ""id"": ""1a24c1b6-1e30-4709-a9e5-c8e95e9274dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""400f2d68-03b1-464e-91e2-66184bd7c691"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c21f42ce-d484-410f-9de7-1cac4d6bb29d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bff78093-6a0e-4f4a-bbb0-bea6e51ec143"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""57738512-9ce5-464f-8721-e3d8cbac0c22"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""639544cc-c122-486c-b075-510edf601faa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ff6cc5ce-a373-4c05-be03-0f03cf07a2d2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0737722b-0204-4393-9bf8-8b78546ea8cc"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebe7f2fd-7678-4991-a5a0-c0f8a2c6b841"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78cc3140-c83b-4f51-9400-a589e1025418"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keybord_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93be2ad1-38c6-4e94-a1b2-cc092b04a004"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keybord_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd61fa9e-f2e2-4f9a-b478-d7a120df98ea"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keybord_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b62c1df-a6a3-48e9-b732-020c0f421317"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keybord_4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Character
            m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
            m_Character_Fire = m_Character.FindAction("Fire", throwIfNotFound: true);
            m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
            m_Character_Aim = m_Character.FindAction("Aim", throwIfNotFound: true);
            m_Character_Run = m_Character.FindAction("Run", throwIfNotFound: true);
            m_Character_Keybord_1 = m_Character.FindAction("Keybord_1", throwIfNotFound: true);
            m_Character_Keybord_2 = m_Character.FindAction("Keybord_2", throwIfNotFound: true);
            m_Character_Keybord_3 = m_Character.FindAction("Keybord_3", throwIfNotFound: true);
            m_Character_Keybord_4 = m_Character.FindAction("Keybord_4", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Character
        private readonly InputActionMap m_Character;
        private List<ICharacterActions> m_CharacterActionsCallbackInterfaces = new List<ICharacterActions>();
        private readonly InputAction m_Character_Fire;
        private readonly InputAction m_Character_Movement;
        private readonly InputAction m_Character_Aim;
        private readonly InputAction m_Character_Run;
        private readonly InputAction m_Character_Keybord_1;
        private readonly InputAction m_Character_Keybord_2;
        private readonly InputAction m_Character_Keybord_3;
        private readonly InputAction m_Character_Keybord_4;
        public struct CharacterActions
        {
            private @PlayerControls m_Wrapper;
            public CharacterActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Fire => m_Wrapper.m_Character_Fire;
            public InputAction @Movement => m_Wrapper.m_Character_Movement;
            public InputAction @Aim => m_Wrapper.m_Character_Aim;
            public InputAction @Run => m_Wrapper.m_Character_Run;
            public InputAction @Keybord_1 => m_Wrapper.m_Character_Keybord_1;
            public InputAction @Keybord_2 => m_Wrapper.m_Character_Keybord_2;
            public InputAction @Keybord_3 => m_Wrapper.m_Character_Keybord_3;
            public InputAction @Keybord_4 => m_Wrapper.m_Character_Keybord_4;
            public InputActionMap Get() { return m_Wrapper.m_Character; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
            public void AddCallbacks(ICharacterActions instance)
            {
                if (instance == null || m_Wrapper.m_CharacterActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_CharacterActionsCallbackInterfaces.Add(instance);
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Keybord_1.started += instance.OnKeybord_1;
                @Keybord_1.performed += instance.OnKeybord_1;
                @Keybord_1.canceled += instance.OnKeybord_1;
                @Keybord_2.started += instance.OnKeybord_2;
                @Keybord_2.performed += instance.OnKeybord_2;
                @Keybord_2.canceled += instance.OnKeybord_2;
                @Keybord_3.started += instance.OnKeybord_3;
                @Keybord_3.performed += instance.OnKeybord_3;
                @Keybord_3.canceled += instance.OnKeybord_3;
                @Keybord_4.started += instance.OnKeybord_4;
                @Keybord_4.performed += instance.OnKeybord_4;
                @Keybord_4.canceled += instance.OnKeybord_4;
            }

            private void UnregisterCallbacks(ICharacterActions instance)
            {
                @Fire.started -= instance.OnFire;
                @Fire.performed -= instance.OnFire;
                @Fire.canceled -= instance.OnFire;
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Aim.started -= instance.OnAim;
                @Aim.performed -= instance.OnAim;
                @Aim.canceled -= instance.OnAim;
                @Run.started -= instance.OnRun;
                @Run.performed -= instance.OnRun;
                @Run.canceled -= instance.OnRun;
                @Keybord_1.started -= instance.OnKeybord_1;
                @Keybord_1.performed -= instance.OnKeybord_1;
                @Keybord_1.canceled -= instance.OnKeybord_1;
                @Keybord_2.started -= instance.OnKeybord_2;
                @Keybord_2.performed -= instance.OnKeybord_2;
                @Keybord_2.canceled -= instance.OnKeybord_2;
                @Keybord_3.started -= instance.OnKeybord_3;
                @Keybord_3.performed -= instance.OnKeybord_3;
                @Keybord_3.canceled -= instance.OnKeybord_3;
                @Keybord_4.started -= instance.OnKeybord_4;
                @Keybord_4.performed -= instance.OnKeybord_4;
                @Keybord_4.canceled -= instance.OnKeybord_4;
            }

            public void RemoveCallbacks(ICharacterActions instance)
            {
                if (m_Wrapper.m_CharacterActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ICharacterActions instance)
            {
                foreach (var item in m_Wrapper.m_CharacterActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_CharacterActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public CharacterActions @Character => new CharacterActions(this);
        public interface ICharacterActions
        {
            void OnFire(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
            void OnAim(InputAction.CallbackContext context);
            void OnRun(InputAction.CallbackContext context);
            void OnKeybord_1(InputAction.CallbackContext context);
            void OnKeybord_2(InputAction.CallbackContext context);
            void OnKeybord_3(InputAction.CallbackContext context);
            void OnKeybord_4(InputAction.CallbackContext context);
        }
    }
}
