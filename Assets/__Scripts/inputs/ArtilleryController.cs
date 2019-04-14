using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class ArtilleryController : MonoBehaviour, IArtilleryActions
{
    [SerializeField] private InputMaster inputMaster;
    [SerializeField] private Transform turret, barrel;
    private float turnIncrement = 0, aimIncrement = 0;

    private void Awake()
    {
        inputMaster.Artillery.SetCallbacks(this);
    }

    private void OnEnable()
    {
        inputMaster.Enable();
    }
    private void OnDisable()
    {
        inputMaster.Disable();
    }

    private void Update()
    {

        turret.transform.Rotate(new Vector3(0, 0, 1), turnIncrement);
        Debug.Log((int) barrel.transform.localEulerAngles.x + " wtf " + aimIncrement);
        if(barrel.transform.localEulerAngles.x + aimIncrement < 15 || barrel.transform.localEulerAngles.x + aimIncrement > 340)
            barrel.transform.Rotate(new Vector3(1, 0, 0), aimIncrement);
    }
    public void OnRotateX(InputAction.CallbackContext context)
    {
        //Todo: Rotate turret (left&right)
        var direction = context.ReadValue<Vector2>();
        //Warning: Calculate rotation first (stick from gamepad)
        turnIncrement = direction[0];
    }

    public void OnRotateY(InputAction.CallbackContext context)
    {
        //Todo: Rotate canon (up&down)
        var direction = context.ReadValue<Vector2>();
        //Warning: Calculate rotation first (stick from gamepad)
        aimIncrement = direction[1];
    }
}
