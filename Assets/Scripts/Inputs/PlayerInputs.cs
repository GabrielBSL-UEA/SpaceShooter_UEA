// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Spaceship"",
            ""id"": ""292dbf74-329a-42eb-8cde-364655f5fad3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""2ecb68d4-ebb0-4221-b01f-6addf4d180b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""0161abd6-38f1-48e0-837c-86c779fe954a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponPlus"",
                    ""type"": ""Button"",
                    ""id"": ""bfbe3c1f-b3be-46a5-8f80-6bdb67f84ee3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponMinus"",
                    ""type"": ""Button"",
                    ""id"": ""02a24bac-e3ae-4ab6-98cd-8a9233097519"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8557b9d9-194f-4fd2-bc5f-9d8f95276290"",
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
                    ""id"": ""24055f39-9d76-4662-aca6-680f12eed2cb"",
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
                    ""id"": ""4bee15c9-8b32-431e-add7-631122396366"",
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
                    ""id"": ""8dd51691-b893-413c-bc31-d5bd2d577b40"",
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
                    ""id"": ""e874a750-33e9-4e3b-b2d3-ca039afa8d01"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""f97988ba-2ac5-4d1b-a2d8-07094e201498"",
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
                    ""id"": ""f79c0594-ae5f-4828-97dd-6a52c230a8ec"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f641fd52-68d7-427b-8cfd-ccaca32990f0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""31fb06ff-bba7-459e-8700-ccf1ae163d47"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2ab40143-4637-4641-bfaa-67ab73b6a719"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d12aeff5-9307-423e-b383-e12f5662f13a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bce982ac-0bb6-47e9-87af-bdd92748a3d5"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponPlus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ced9692-93ae-4831-8304-c4bdb8a7459a"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponPlus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f093fdbc-8ae0-4ba5-9337-61dcaf6b149e"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponMinus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""437f1bfa-dc9a-42e8-847e-46b3f8c95694"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponMinus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Spaceship
        m_Spaceship = asset.FindActionMap("Spaceship", throwIfNotFound: true);
        m_Spaceship_Movement = m_Spaceship.FindAction("Movement", throwIfNotFound: true);
        m_Spaceship_Shoot = m_Spaceship.FindAction("Shoot", throwIfNotFound: true);
        m_Spaceship_WeaponPlus = m_Spaceship.FindAction("WeaponPlus", throwIfNotFound: true);
        m_Spaceship_WeaponMinus = m_Spaceship.FindAction("WeaponMinus", throwIfNotFound: true);
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

    // Spaceship
    private readonly InputActionMap m_Spaceship;
    private ISpaceshipActions m_SpaceshipActionsCallbackInterface;
    private readonly InputAction m_Spaceship_Movement;
    private readonly InputAction m_Spaceship_Shoot;
    private readonly InputAction m_Spaceship_WeaponPlus;
    private readonly InputAction m_Spaceship_WeaponMinus;
    public struct SpaceshipActions
    {
        private @PlayerInputs m_Wrapper;
        public SpaceshipActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Spaceship_Movement;
        public InputAction @Shoot => m_Wrapper.m_Spaceship_Shoot;
        public InputAction @WeaponPlus => m_Wrapper.m_Spaceship_WeaponPlus;
        public InputAction @WeaponMinus => m_Wrapper.m_Spaceship_WeaponMinus;
        public InputActionMap Get() { return m_Wrapper.m_Spaceship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpaceshipActions set) { return set.Get(); }
        public void SetCallbacks(ISpaceshipActions instance)
        {
            if (m_Wrapper.m_SpaceshipActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnShoot;
                @WeaponPlus.started -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnWeaponPlus;
                @WeaponPlus.performed -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnWeaponPlus;
                @WeaponPlus.canceled -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnWeaponPlus;
                @WeaponMinus.started -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnWeaponMinus;
                @WeaponMinus.performed -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnWeaponMinus;
                @WeaponMinus.canceled -= m_Wrapper.m_SpaceshipActionsCallbackInterface.OnWeaponMinus;
            }
            m_Wrapper.m_SpaceshipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @WeaponPlus.started += instance.OnWeaponPlus;
                @WeaponPlus.performed += instance.OnWeaponPlus;
                @WeaponPlus.canceled += instance.OnWeaponPlus;
                @WeaponMinus.started += instance.OnWeaponMinus;
                @WeaponMinus.performed += instance.OnWeaponMinus;
                @WeaponMinus.canceled += instance.OnWeaponMinus;
            }
        }
    }
    public SpaceshipActions @Spaceship => new SpaceshipActions(this);
    public interface ISpaceshipActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnWeaponPlus(InputAction.CallbackContext context);
        void OnWeaponMinus(InputAction.CallbackContext context);
    }
}
