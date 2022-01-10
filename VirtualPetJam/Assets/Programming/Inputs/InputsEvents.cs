using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsEvents : MonoBehaviour
{
    CameraObj m_cameraObj;

    Vector2 movement;

    public void SetCameraObj(CameraObj cameraObj)
    {
        m_cameraObj = cameraObj;
    }

    public void Movement(InputAction.CallbackContext context)
    {
        if (context.performed)
            movement = new Vector2(Mathf.RoundToInt(context.ReadValue<Vector2>().x), Mathf.RoundToInt(context.ReadValue<Vector2>().y));
    }

    void LateUpdate()
    {
        if (movement.x != 0)
            movement = new Vector2(movement.x, 0);
        
        if (movement.x != 0 || movement.y != 0)
        {
            movement = m_cameraObj.ChangeRoom(movement);
            m_cameraObj.MoveCamera(movement);
        }
        movement = new Vector2(0,0);
    }
}
