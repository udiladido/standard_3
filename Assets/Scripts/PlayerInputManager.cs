using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    
}

#region ���Ž� ���
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

#region ���̷�Ʈ ���
//public class PlayerInputManager : MonoBehaviour
//{
//    // ��ǲ�ý��� - ���̷�Ʈ

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

#region �Ӻ���� ���
//public class PlayerInputManager : MonoBehaviour
//{
//    // ��ǲ�ý��� - �Ӻ���� ���

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

#region �׼� ���� ���
//public class PlayerInputManager : MonoBehaviour
//{
//    // ��ǲ�ý��� - �׼� ���� ���

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

#region C# ���ʷ���Ʈ ���
//public class PlayerInputManager : MonoBehaviour
//{
//    // ��ǲ�ý��� - C# ���ʷ���Ʈ ���

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