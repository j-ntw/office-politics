//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Characters/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerMap"",
            ""id"": ""91803f71-df13-480d-8806-02078224a81b"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""604dbd9b-1597-4cb9-9a21-6e837ddf1ba4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PlayPause"",
                    ""type"": ""Button"",
                    ""id"": ""dec4df0d-9978-4843-8716-7d51cf85bdbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""interact"",
                    ""type"": ""Button"",
                    ""id"": ""3ecee67b-67fd-4c60-b56e-345de4cd56a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""cycleConsumable"",
                    ""type"": ""Button"",
                    ""id"": ""88452cb0-55dc-4bde-81c7-5312682ccb2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""useConsumable1"",
                    ""type"": ""Button"",
                    ""id"": ""ec2172b2-ee34-47f6-a6cc-e141936c1efa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""useConsumable2"",
                    ""type"": ""Button"",
                    ""id"": ""ef7be87c-bca3-4f4c-8fa9-9665d940c917"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""evade"",
                    ""type"": ""Button"",
                    ""id"": ""aa92cd4d-b114-48b1-9ba7-4cd9e2583acb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""pullupTask"",
                    ""type"": ""Button"",
                    ""id"": ""ed7d17a3-3974-4e0a-895b-01155bdde3fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f9cae7fd-fa74-493c-9983-0058934dd174"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ac102d76-cb9c-47a8-9206-7a4619ce4815"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""OfficePolitics;Keyboard&Mouse;Gamepad;Touch;Joystick;XR"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e96bb39c-2b65-43dc-8906-366bc19ef0da"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""OfficePolitics;Keyboard&Mouse;Gamepad;Touch;Joystick;XR"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b4fd7d44-6936-4121-8996-d4d70203526c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""OfficePolitics;Keyboard&Mouse;Gamepad;Touch;Joystick;XR"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""113ad31a-c89a-47e4-9ace-08c79137afc3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""OfficePolitics;XR;Joystick;Touch;Gamepad;Keyboard&Mouse"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector [Arrow]"",
                    ""id"": ""a0454d97-cef0-443a-8618-af91ea6f084c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fa60030e-4002-4eab-a919-93b908341175"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""OfficePolitics"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7de6dbee-b928-46d6-aa29-41987e26ddaa"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""OfficePolitics"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b029151a-66c3-401f-8fb0-2aadc0b09e12"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""OfficePolitics"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0f155069-ad7f-4a01-b484-6613a463facf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""OfficePolitics"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""76289708-b0f9-46a4-a7a6-3b0388406361"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""OfficePolitics;Keyboard&Mouse;Touch;Gamepad;Joystick;XR"",
                    ""action"": ""interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70d251bf-7878-44f4-b96b-c1e5ea17b791"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cycleConsumable"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9c5fbc8-2ab5-400a-a8c6-46ce858cb7a9"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""useConsumable1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c40b169a-4203-486e-948c-27ba0b84200c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""evade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""286a4a00-2f8b-4c08-bfc6-cf5042acecd7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;OfficePolitics"",
                    ""action"": ""PlayPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adbbe8d0-123e-4f9e-a590-624d6e01ee34"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;OfficePolitics;Gamepad;Touch;Joystick;XR"",
                    ""action"": ""pullupTask"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9c8e6f2-a622-4447-a675-46d99a9c7d73"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""useConsumable2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""OfficePolitics"",
            ""bindingGroup"": ""OfficePolitics"",
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
        }
    ]
}");
        // PlayerMap
        m_PlayerMap = asset.FindActionMap("PlayerMap", throwIfNotFound: true);
        m_PlayerMap_move = m_PlayerMap.FindAction("move", throwIfNotFound: true);
        m_PlayerMap_PlayPause = m_PlayerMap.FindAction("PlayPause", throwIfNotFound: true);
        m_PlayerMap_interact = m_PlayerMap.FindAction("interact", throwIfNotFound: true);
        m_PlayerMap_cycleConsumable = m_PlayerMap.FindAction("cycleConsumable", throwIfNotFound: true);
        m_PlayerMap_useConsumable1 = m_PlayerMap.FindAction("useConsumable1", throwIfNotFound: true);
        m_PlayerMap_useConsumable2 = m_PlayerMap.FindAction("useConsumable2", throwIfNotFound: true);
        m_PlayerMap_evade = m_PlayerMap.FindAction("evade", throwIfNotFound: true);
        m_PlayerMap_pullupTask = m_PlayerMap.FindAction("pullupTask", throwIfNotFound: true);
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

    // PlayerMap
    private readonly InputActionMap m_PlayerMap;
    private List<IPlayerMapActions> m_PlayerMapActionsCallbackInterfaces = new List<IPlayerMapActions>();
    private readonly InputAction m_PlayerMap_move;
    private readonly InputAction m_PlayerMap_PlayPause;
    private readonly InputAction m_PlayerMap_interact;
    private readonly InputAction m_PlayerMap_cycleConsumable;
    private readonly InputAction m_PlayerMap_useConsumable1;
    private readonly InputAction m_PlayerMap_useConsumable2;
    private readonly InputAction m_PlayerMap_evade;
    private readonly InputAction m_PlayerMap_pullupTask;
    public struct PlayerMapActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerMapActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_PlayerMap_move;
        public InputAction @PlayPause => m_Wrapper.m_PlayerMap_PlayPause;
        public InputAction @interact => m_Wrapper.m_PlayerMap_interact;
        public InputAction @cycleConsumable => m_Wrapper.m_PlayerMap_cycleConsumable;
        public InputAction @useConsumable1 => m_Wrapper.m_PlayerMap_useConsumable1;
        public InputAction @useConsumable2 => m_Wrapper.m_PlayerMap_useConsumable2;
        public InputAction @evade => m_Wrapper.m_PlayerMap_evade;
        public InputAction @pullupTask => m_Wrapper.m_PlayerMap_pullupTask;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMapActionsCallbackInterfaces.Add(instance);
            @move.started += instance.OnMove;
            @move.performed += instance.OnMove;
            @move.canceled += instance.OnMove;
            @PlayPause.started += instance.OnPlayPause;
            @PlayPause.performed += instance.OnPlayPause;
            @PlayPause.canceled += instance.OnPlayPause;
            @interact.started += instance.OnInteract;
            @interact.performed += instance.OnInteract;
            @interact.canceled += instance.OnInteract;
            @cycleConsumable.started += instance.OnCycleConsumable;
            @cycleConsumable.performed += instance.OnCycleConsumable;
            @cycleConsumable.canceled += instance.OnCycleConsumable;
            @useConsumable1.started += instance.OnUseConsumable1;
            @useConsumable1.performed += instance.OnUseConsumable1;
            @useConsumable1.canceled += instance.OnUseConsumable1;
            @useConsumable2.started += instance.OnUseConsumable2;
            @useConsumable2.performed += instance.OnUseConsumable2;
            @useConsumable2.canceled += instance.OnUseConsumable2;
            @evade.started += instance.OnEvade;
            @evade.performed += instance.OnEvade;
            @evade.canceled += instance.OnEvade;
            @pullupTask.started += instance.OnPullupTask;
            @pullupTask.performed += instance.OnPullupTask;
            @pullupTask.canceled += instance.OnPullupTask;
        }

        private void UnregisterCallbacks(IPlayerMapActions instance)
        {
            @move.started -= instance.OnMove;
            @move.performed -= instance.OnMove;
            @move.canceled -= instance.OnMove;
            @PlayPause.started -= instance.OnPlayPause;
            @PlayPause.performed -= instance.OnPlayPause;
            @PlayPause.canceled -= instance.OnPlayPause;
            @interact.started -= instance.OnInteract;
            @interact.performed -= instance.OnInteract;
            @interact.canceled -= instance.OnInteract;
            @cycleConsumable.started -= instance.OnCycleConsumable;
            @cycleConsumable.performed -= instance.OnCycleConsumable;
            @cycleConsumable.canceled -= instance.OnCycleConsumable;
            @useConsumable1.started -= instance.OnUseConsumable1;
            @useConsumable1.performed -= instance.OnUseConsumable1;
            @useConsumable1.canceled -= instance.OnUseConsumable1;
            @useConsumable2.started -= instance.OnUseConsumable2;
            @useConsumable2.performed -= instance.OnUseConsumable2;
            @useConsumable2.canceled -= instance.OnUseConsumable2;
            @evade.started -= instance.OnEvade;
            @evade.performed -= instance.OnEvade;
            @evade.canceled -= instance.OnEvade;
            @pullupTask.started -= instance.OnPullupTask;
            @pullupTask.performed -= instance.OnPullupTask;
            @pullupTask.canceled -= instance.OnPullupTask;
        }

        public void RemoveCallbacks(IPlayerMapActions instance)
        {
            if (m_Wrapper.m_PlayerMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMapActions @PlayerMap => new PlayerMapActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
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
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    private int m_OfficePoliticsSchemeIndex = -1;
    public InputControlScheme OfficePoliticsScheme
    {
        get
        {
            if (m_OfficePoliticsSchemeIndex == -1) m_OfficePoliticsSchemeIndex = asset.FindControlSchemeIndex("OfficePolitics");
            return asset.controlSchemes[m_OfficePoliticsSchemeIndex];
        }
    }
    public interface IPlayerMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPlayPause(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnCycleConsumable(InputAction.CallbackContext context);
        void OnUseConsumable1(InputAction.CallbackContext context);
        void OnUseConsumable2(InputAction.CallbackContext context);
        void OnEvade(InputAction.CallbackContext context);
        void OnPullupTask(InputAction.CallbackContext context);
    }
}
