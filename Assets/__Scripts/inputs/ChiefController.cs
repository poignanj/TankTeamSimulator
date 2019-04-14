using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class ChiefController : MonoBehaviour, IChiefControlsActions
{
    public void OnClick(InputAction.CallbackContext context)
    {
        //Todo: Send message (distance & direction) to Artillery
    }

    public void OnLookAround(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
    
}
