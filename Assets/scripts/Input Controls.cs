//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/scripts/Input Controls.inputactions
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

public partial class @InputControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerDrone"",
            ""id"": ""1ea1d5e5-0171-42fb-9382-ad5ea7cf8b42"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""d2f339b1-99e6-40a7-ad56-0303f11ae678"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""725ee2b7-7b53-4962-9068-248caeb37985"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""9528a4db-7871-45cd-b735-2909a21b34ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""c0c4cbc2-05fc-4935-a8bf-648bea090f66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""286e35a7-24cc-4406-a42c-d7709bcd2415"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59dd61e6-44c0-4d3d-a419-cd2c6f845868"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ba6544d0-8b6f-43b9-bdc4-c138ae405d8d"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2a48391d-de60-43c1-9389-80c40f443ca8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8faf304f-085f-48b2-bcef-a2e0182fbd05"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8d2210a8-3964-4d70-a37e-cf098fdca35f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c13a498c-d75a-4c46-a4f6-abd30c9e2f7e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""9fb35c27-6dc7-48ca-bd44-dcff93533117"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""53fe9eaa-502e-4289-a7ec-80b0178be68d"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d91d5ab9-5429-407d-a014-5e6655dc2b31"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f30693e-7f93-41ec-9419-0c899e32a4ba"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraDrone"",
            ""id"": ""4afaa18e-2c86-495b-9774-b0d4aedaaeca"",
            ""actions"": [
                {
                    ""name"": ""Photo"",
                    ""type"": ""Button"",
                    ""id"": ""e051a842-db9b-4fc2-bbe4-ad8ed79b8dd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""76482531-4484-4ef8-9cd9-8822b0a96366"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d3109040-cca3-4fe1-8974-9653f9c9a5ba"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Photo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3176de30-f538-416b-90dd-a8e136b7f459"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Photo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""54b74a7f-c37f-4545-85f2-5b7f4e91a7f8"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""59848c54-44cd-4f75-872c-8ce8e6bf4da7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""33868453-b278-4159-9c73-a1cd53f158eb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""64c5abda-b47c-4769-8390-ec6044054c81"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""59a7cb10-1d76-435e-b2de-0bd00a2db258"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""820d688e-2a39-475b-a0de-d3186a07c50c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""1dd81edc-a9cd-4feb-97d9-781ab2b0bdbf"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerDrone
        m_PlayerDrone = asset.FindActionMap("PlayerDrone", throwIfNotFound: true);
        m_PlayerDrone_Attack = m_PlayerDrone.FindAction("Attack", throwIfNotFound: true);
        m_PlayerDrone_Move = m_PlayerDrone.FindAction("Move", throwIfNotFound: true);
        m_PlayerDrone_Pause = m_PlayerDrone.FindAction("Pause", throwIfNotFound: true);
        m_PlayerDrone_Menu = m_PlayerDrone.FindAction("Menu", throwIfNotFound: true);
        // CameraDrone
        m_CameraDrone = asset.FindActionMap("CameraDrone", throwIfNotFound: true);
        m_CameraDrone_Photo = m_CameraDrone.FindAction("Photo", throwIfNotFound: true);
        m_CameraDrone_Move = m_CameraDrone.FindAction("Move", throwIfNotFound: true);
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

    // PlayerDrone
    private readonly InputActionMap m_PlayerDrone;
    private List<IPlayerDroneActions> m_PlayerDroneActionsCallbackInterfaces = new List<IPlayerDroneActions>();
    private readonly InputAction m_PlayerDrone_Attack;
    private readonly InputAction m_PlayerDrone_Move;
    private readonly InputAction m_PlayerDrone_Pause;
    private readonly InputAction m_PlayerDrone_Menu;
    public struct PlayerDroneActions
    {
        private @InputControls m_Wrapper;
        public PlayerDroneActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_PlayerDrone_Attack;
        public InputAction @Move => m_Wrapper.m_PlayerDrone_Move;
        public InputAction @Pause => m_Wrapper.m_PlayerDrone_Pause;
        public InputAction @Menu => m_Wrapper.m_PlayerDrone_Menu;
        public InputActionMap Get() { return m_Wrapper.m_PlayerDrone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerDroneActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerDroneActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerDroneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerDroneActionsCallbackInterfaces.Add(instance);
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Menu.started += instance.OnMenu;
            @Menu.performed += instance.OnMenu;
            @Menu.canceled += instance.OnMenu;
        }

        private void UnregisterCallbacks(IPlayerDroneActions instance)
        {
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Menu.started -= instance.OnMenu;
            @Menu.performed -= instance.OnMenu;
            @Menu.canceled -= instance.OnMenu;
        }

        public void RemoveCallbacks(IPlayerDroneActions instance)
        {
            if (m_Wrapper.m_PlayerDroneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerDroneActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerDroneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerDroneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerDroneActions @PlayerDrone => new PlayerDroneActions(this);

    // CameraDrone
    private readonly InputActionMap m_CameraDrone;
    private List<ICameraDroneActions> m_CameraDroneActionsCallbackInterfaces = new List<ICameraDroneActions>();
    private readonly InputAction m_CameraDrone_Photo;
    private readonly InputAction m_CameraDrone_Move;
    public struct CameraDroneActions
    {
        private @InputControls m_Wrapper;
        public CameraDroneActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Photo => m_Wrapper.m_CameraDrone_Photo;
        public InputAction @Move => m_Wrapper.m_CameraDrone_Move;
        public InputActionMap Get() { return m_Wrapper.m_CameraDrone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraDroneActions set) { return set.Get(); }
        public void AddCallbacks(ICameraDroneActions instance)
        {
            if (instance == null || m_Wrapper.m_CameraDroneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CameraDroneActionsCallbackInterfaces.Add(instance);
            @Photo.started += instance.OnPhoto;
            @Photo.performed += instance.OnPhoto;
            @Photo.canceled += instance.OnPhoto;
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(ICameraDroneActions instance)
        {
            @Photo.started -= instance.OnPhoto;
            @Photo.performed -= instance.OnPhoto;
            @Photo.canceled -= instance.OnPhoto;
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(ICameraDroneActions instance)
        {
            if (m_Wrapper.m_CameraDroneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICameraDroneActions instance)
        {
            foreach (var item in m_Wrapper.m_CameraDroneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CameraDroneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CameraDroneActions @CameraDrone => new CameraDroneActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerDroneActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface ICameraDroneActions
    {
        void OnPhoto(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}