﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class inputVR_tankor : MonoBehaviour
{

    [Space] [SerializeField] private Transform Left, Right;
    [Space] [SerializeField] private GameObject Spawn_GO_R, Spawn_GO_G;
    private GameObject FlagRed, FlagGreen; //Aff0
    private GameObject CameraVR;
    
    private int defMask;
    [SerializeField] private GameObject gunner;
    [SerializeField] private GameObject pilot;


    [Space] public Canvas proneCanvas;
    // Start is called before the first frame update
    void Start()
    {
        CameraVR = GetComponentInChildren<Camera>().gameObject;
        //defMask = CameraVR.GetComponent<Camera>().cullingMask;
        //proneCanvas = CameraVR.GetComponentInChildren<Canvas>();
        proneCanvas.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(SteamVR_Input.GetStateDown("InteractUI", SteamVR_Input_Sources.RightHand))
        {
            Debug.Log("Try Hit Right");
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
        if (SteamVR_Input.GetStateDown("InteractUI", SteamVR_Input_Sources.LeftHand))
        {

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="CameraVR")
        {
            //todo: disable
            Debug.Log("J'suis caché");
            proneCanvas.enabled =true;
            //CameraVR.GetComponent<Camera>().cullingMask = 0;
            //CameraVR.GetComponent<Camera>().clearFlags = CameraClearFlags.Color;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name=="CameraVR")
        {
            //todo: disable
            Debug.Log("J'suis debout");
            proneCanvas.enabled =false;
            //CameraVR.GetComponent<Camera>().cullingMask = defMask;
            //CameraVR.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
        }
    }

        
}
