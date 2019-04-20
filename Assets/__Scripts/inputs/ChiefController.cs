using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class ChiefController : MonoBehaviour, IChiefControlsActions
{
    [SerializeField] private InputMaster inputMaster;

    private void Awake()
    {
        inputMaster.ChiefControls.SetCallbacks(this);
    }

    private void OnEnable()
    {
        inputMaster.Enable();
    }
    private void OnDisable()
    {
        inputMaster.Disable();
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        //Todo: Send message (distance & direction) to Artillery
    }
    
    
}
