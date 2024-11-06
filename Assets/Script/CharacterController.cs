using System;
using UnityEngine.InputSystem;
using UnityEngine;

public class CharacterController : MonoBehaviour
{


    [Header("Movement")]
    public float moveSpeed;
    private Vector2 curMovementInput;
    public float jumptForce;
    public LayerMask groundLayerMask;

    [Header("Look")]
    public Transform cameraContainer;
    public float minXLook;
    public float maxXLook;
    public float minYLook;
    public float maxYLook;
    private float camCurXRot;
    private float camCurYRot;
    public float lookSensitivity;

    private Vector2 mouseDelta;
    private Rigidbody rigidbody;

    bool canLook = true;

    public event Action<Vector2> OnLookEvent;
    public event Action OnUI;

    private void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    public void CallLookEvent(Vector2 direction)
    {

        if (canLook)
        {

            OnLookEvent?.Invoke(direction);

        }
    }


    private void LateUpdate()
    {
        if (canLook)
        {
            CameraLook();
        }
    }


    private void FixedUpdate()
    {
        Move();
    }


    private void Move()
    {
        Vector3 dir = transform.forward * curMovementInput.y + transform.right * curMovementInput.x;
        dir *= moveSpeed;
        dir.y = rigidbody.velocity.y;

        rigidbody.velocity = dir;
    }


    public void CallUIEvent()
    { 
    
         OnUI?.Invoke();
        
    }

    public void OnLookInput(InputAction.CallbackContext context)
    {
        mouseDelta = context.ReadValue<Vector2>();
    }


    void CameraLook()
    {
        camCurXRot += mouseDelta.y * lookSensitivity;
        camCurXRot = Mathf.Clamp(camCurXRot, minXLook, maxXLook);
        cameraContainer.localEulerAngles = new Vector3(-camCurXRot, 0, 0);

        transform.eulerAngles += new Vector3(0, mouseDelta.x * lookSensitivity, 0);
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            curMovementInput = context.ReadValue<Vector2>();
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            curMovementInput = Vector2.zero;
        }
    }


}
