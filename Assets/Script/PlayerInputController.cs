using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController
{
    
 
    public void OnLook(InputValue value)
    {

        Vector2 moveInput = value.Get<Vector2>();



        CallLookEvent(moveInput);
        
    }







}
