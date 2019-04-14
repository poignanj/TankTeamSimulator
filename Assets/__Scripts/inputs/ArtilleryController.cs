using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class ArtilleryController : MonoBehaviour, IArtilleryActions
{
    public void OnRotateX(InputAction.CallbackContext context)
    {
        //Todo: Rotate turret (left&right)
        //Warning: Calculate rotation first (stick from gamepad)
    }

    public void OnRotateY(InputAction.CallbackContext context)
    {
        //Todo: Rotate canon (up&down)
        //Warning: Calculate rotation first (stick from gamepad)
    }
}
