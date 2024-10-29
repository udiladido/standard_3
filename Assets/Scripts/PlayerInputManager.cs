using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    
}

#region 레거시 방식
//public class PlayerInputManager : MonoBehaviour
//{
//    public float dir;

//    private void Update()
//    {
//        if (Input.GetKey(KeyCode.A))
//        {
//            dir = -1;
//        }
//        else if (Input.GetKey(KeyCode.D))
//        {
//            dir = 1;
//        }
//        else
//        {
//            dir = 0;
//        }
//    }
//}

#endregion

#region 다이렉트 방식
//public class PlayerInputManager : MonoBehaviour
//{
//    // 인풋시스템 - 다이렉트

//    public float dir;

//    Keyboard keyboard;
//    Mouse mouse;
//    Gamepad gamepad;

//    private void Start()
//    {
//        keyboard = Keyboard.current;
//        mouse = Mouse.current;
//        gamepad = Gamepad.current;
//    }

//    private void Update()
//    {
//        if (keyboard.aKey.isPressed)
//        {
//            dir = -1;
//        }
//        else if (keyboard.dKey.wasPressedThisFrame)
//        {
//            dir = 1;
//        }
//        else
//        {
//            dir = 0;
//        }

//        //keyboard.aKey.wasPressedThisFrame;
//        //keyboard.aKey.isPressed;
//        //keyboard.aKey.wasReleasedThisFrame;
//        //mouse.scroll.ReadValue();
//        //gamepad.dpad.ReadValue();
//    }
//}

#endregion

#region 임베디드 방식
//public class PlayerInputManager : MonoBehaviour
//{
//    // 인풋시스템 - 임베디드 방식

//    public float dir;

//    public UnityAction jumpEvent;

//    public InputAction moveAction;
//    public InputAction jumpAction;

//    private void OnEnable()
//    {
//        moveAction.performed += PlayerMove;
//        moveAction.canceled += PlyerStop;

//        jumpAction.started += PlayerJump;

//        moveAction.Enable();
//        jumpAction.Enable();
//    }

//    private void OnDisable()
//    {
//        moveAction.Disable();
//        jumpAction.Disable();

//        jumpAction.started -= PlayerJump;
//        moveAction.performed -= PlayerMove;
//        moveAction.canceled -= PlyerStop;
//    }

//    void PlayerMove(InputAction.CallbackContext value)
//    {
//        dir = value.ReadValue<float>();
//    }

//    void PlyerStop(InputAction.CallbackContext value)
//    {
//        dir = 0;
//    }

//    void PlayerJump(InputAction.CallbackContext value)
//    {
//        jumpEvent?.Invoke();
//    }
//}

#endregion

#region 액션 에셋 방식
//public class PlayerInputManager : MonoBehaviour
//{
//    // 인풋시스템 - 액션 에셋 방식

//    public float dir;
//    public UnityAction jumpEvent;

//    public InputActionAsset inputAsset;

//    InputActionMap basic;

//    InputAction moveAction;
//    InputAction jumpAction;


//    private void OnEnable()
//    {
//        basic = inputAsset.FindActionMap("Basic");

//        moveAction = basic.FindAction("Move");
//        jumpAction = basic.FindAction("Jump");

//        moveAction.performed += PlayerMove;
//        moveAction.canceled += PlyerStop;
//        jumpAction.started += PlayerJump;

//        basic.Enable();
//        //moveAction.Enable();
//        //jumpAction.Enable();
//    }

//    private void OnDisable()
//    {
//        basic.Disable();
//        //moveAction.Disable();
//        //jumpAction.Disable();

//        jumpAction.started -= PlayerJump;
//        moveAction.performed -= PlayerMove;
//        moveAction.canceled -= PlyerStop;
//    }

//    void PlayerMove(InputAction.CallbackContext value)
//    {
//        dir = value.ReadValue<float>();
//    }

//    void PlyerStop(InputAction.CallbackContext value)
//    {
//        dir = 0;
//    }

//    void PlayerJump(InputAction.CallbackContext value)
//    {
//        jumpEvent?.Invoke();
//    }
//}
#endregion

#region C# 제너레이트 방식
//public class PlayerInputManager : MonoBehaviour
//{
//    // 인풋시스템 - C# 제너레이트 방식

//    public float dir;
//    public UnityAction jumpEvent;
//    GameObject ui;
//    bool isPlaying = true;

//    PlayerInput input;

//    InputActionMap basic;

//    InputAction moveAction;
//    InputAction jumpAction;


//    private void OnEnable()
//    {
//        ui = GameObject.Find("UICanvas");
//        ui.SetActive(false);

//        input = new PlayerInput();

//        input.Basic.Move.performed += PlayerMove;
//        input.Basic.Move.canceled += PlyerStop;
//        input.Basic.Jump.performed += PlayerJump;

//        input.Changer.Change.started += Change;

//        input.Basic.Enable();
//        input.Changer.Enable();
//    }

//    private void OnDisable()
//    {
//        input.Disable();

//        input.Changer.Change.started -= Change;
//        input.Basic.Move.performed -= PlayerMove;
//        input.Basic.Move.canceled -= PlyerStop;
//        input.Basic.Jump.performed -= PlayerJump;
//    }

//    void Change(InputAction.CallbackContext value)
//    {
//        isPlaying = !isPlaying;
//        ui.SetActive(!isPlaying);
//        Time.timeScale = isPlaying ? 1f : 0f;

//        if (isPlaying)
//        {
//            input.Basic.Enable();
//            input.UI.Disable();
//        }
//        else
//        {
//            input.Basic.Disable();
//            input.UI.Enable();
//        }
//    }


//    void PlayerMove(InputAction.CallbackContext value)
//    {
//        dir = value.ReadValue<float>();
//    }

//    void PlyerStop(InputAction.CallbackContext value)
//    {
//        dir = 0;
//    }

//    void PlayerJump(InputAction.CallbackContext value)
//    {
//        jumpEvent?.Invoke();
//    }
//}
#endregion