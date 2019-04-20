using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class ChiefController : MonoBehaviour, IChiefControlsActions
{
    [SerializeField] private InputMaster inputMaster;
    [Space][SerializeField] private Transform Left, Right;
    [Space][SerializeField] private GameObject Spawn_GO_R, Spawn_GO_G;
    private GameObject FlagRed, FlagGreen; //Aff0

    [SerializeField] private GameObject gunner;
    [SerializeField] private GameObject pilot;

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

    public void OnRClick(InputAction.CallbackContext context)
    {
        //Todo: Send message (distance & direction) to Artillery
        RaycastHit hit;
        if(Physics.Raycast(Right.position, Right.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(Right.position, Right.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit Right");
            if(!FlagGreen)
                FlagGreen = Instantiate(Spawn_GO_G);
            FlagGreen.transform.position = hit.point;
            FlagGreen.GetComponent<SetTarget>().SetMark(gunner);
        }


    }

    public void OnLClick(InputAction.CallbackContext context)
    {
        //Todo: Send message (distance & direction) to Pilot
        RaycastHit hit;
        if (Physics.Raycast(Left.position, Left.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(Left.position, Left.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit Left");
            if (!FlagRed)
                FlagRed = Instantiate(Spawn_GO_R);
            FlagRed.transform.position = hit.point;
            FlagRed.GetComponent<SetTarget>().SetMark(pilot);
            //send 
        }
    }
}
