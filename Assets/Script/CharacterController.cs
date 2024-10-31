using System;
using UnityEngine.InputSystem;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Look")]
    public Transform CameraContainer;
    public float minXLook;
    public float maxXLook;
    public float minYLook;
    public float maxYLook;
    private float CamCurXRot;
    private float CamCurYRot;
    public float lookSensitivity;
 

    bool canLook = true;

    public event Action<Vector2> OnLookEvent;
    public event Action OnUI;

    private void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;

    }


    public void CallLookEvent(Vector2 direction)
    {

        if (canLook)
        {

            OnLookEvent?.Invoke(direction);

        }
    }

    public void CallUIEvent()
    { 
    
         OnUI?.Invoke();
        
    }




}
