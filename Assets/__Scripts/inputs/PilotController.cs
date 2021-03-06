﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;
using UnityEngine.UI;

public class PilotController : MonoBehaviour, IPilotTankActions
{

    public AudioSource m_MovementAudio;         // Reference to the audio source used to play engine sounds. NB: different to the shooting audio source.
    public AudioClip m_EngineIdling;            // Audio to play when the tank isn't moving.
    public AudioClip m_EngineDriving;           // Audio to play when the tank is moving.
    private float m_OriginalPitch;              // The pitch of the audio source at the start of the scene.
    public float m_PitchRange = 0.2f;           // The amount by which the pitch of the engine noises can vary.
    public GameObject chenilledroite;
    public GameObject chenillegauche;



    [SerializeField] private InputMaster inputMaster;
    [SerializeField] public GameObject leftTrack, rightTrack;
    private WheelCollider[] LeftWheels, RightWheels;
    [Space] [SerializeField] private float leftSpeed = 0, rightSpeed = 0, leftfloatspeed = 0, rightfloatspeed = 0;
    private bool onHold = false, leftdisabled = false, rightdisabled =false;
    private float maxSpeed = 60, minSpeed = -30;
    private float gear = 5f;
    private Rigidbody engine;
    private void Awake()
    {
        inputMaster.PilotTank.SetCallbacks(this);
        engine = this.GetComponent<Rigidbody>();
        LeftWheels = leftTrack.GetComponentsInChildren<WheelCollider>();
        RightWheels = rightTrack.GetComponentsInChildren<WheelCollider>();
        chenilledroite.SetActive(false);
        chenillegauche.SetActive(false);

    }

    private void Start()
    {
        // Store the original pitch of the audio source.
        m_OriginalPitch = m_MovementAudio.pitch;
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
        //todo: Adjust speed scaling (percentile?) & Force position
        /*engine.velocity.Set(0, 0, 0);
        engine.angularVelocity.Set(0, 0, 0);
        Vector3 leftpos = leftTrack.position;
        Vector3 rightpos = rightTrack.position;
        //leftpos.y = engine.centerOfMass.y;
        //rightpos.y = engine.centerOfMass.y;
        engine.AddForceAtPosition(this.transform.forward.normalized * leftSpeed, leftpos);
        engine.AddForceAtPosition(this.transform.forward.normalized * rightSpeed, rightpos);*/

        //Right
        foreach(WheelCollider wheel in LeftWheels)
        {
            wheel.motorTorque = leftSpeed;
        }

        //Left
        foreach (WheelCollider wheel in RightWheels)
        {
            wheel.motorTorque = rightSpeed;
        }


        EngineAudio();
    }

    public void OnMoveLeftLever(InputAction.CallbackContext context)
    {
        if (!leftdisabled)
        {
            var direction = context.ReadValue<float>();
            leftSpeed = direction*gear;
        }
        if(leftSpeed < minSpeed)
        {
            leftSpeed = minSpeed;
        }
        if(leftSpeed > maxSpeed)
        {
            leftSpeed = maxSpeed;
        }
    }

    public void OnMoveRightLever(InputAction.CallbackContext context)
    {
        
        if (!rightdisabled)
        {
            var direction = context.ReadValue<float>();
            rightSpeed = direction*gear;
        }
        if (rightSpeed < minSpeed)
        {
            rightSpeed = minSpeed;
        }
        if (rightSpeed > maxSpeed)
        {
            rightSpeed = maxSpeed;
        }
    }

    public void OnStopAll(InputAction.CallbackContext context)
    {
        /*Méthode pour faire une arrêt temporaire
        if (!onHold)
        {
            Debug.Log("put on hold");
            rightfloatspeed = rightSpeed;
            leftfloatspeed = leftSpeed;
            rightSpeed = 0;
            leftSpeed = 0;
            onHold = true;
        }
        else
        {
            Debug.Log("release hold");
            rightSpeed = rightfloatspeed;
            leftSpeed = leftfloatspeed;
            onHold = false;
        }*/
        rightSpeed = 0;
        leftSpeed = 0;
        
        
    }

    public void OnStopLeft(InputAction.CallbackContext context)
    {
        leftSpeed = 0;
        if (rightSpeed > 50)
        {
            rightSpeed = 50;
        }else if (rightSpeed < -50)
        {
            rightSpeed = -50;
        }
    }
    public void OnStopRight(InputAction.CallbackContext context)
    {
        
        rightSpeed = 0;
        if (leftSpeed > 50)
        {
            leftSpeed = 50;
        }
        else if (leftSpeed < -50)
        {
            leftSpeed = -50;
        }
    }

    public void OnRepair(InputAction.CallbackContext context)
    {
        rightdisabled = false;
        leftdisabled = false;
        chenilledroite.SetActive(false);
        chenillegauche.SetActive(false);
    }

    public void DisableLeft()
    {
        Debug.Log("Left has been disabled");
        leftdisabled = true;
        chenillegauche.SetActive(true);
        leftSpeed = 0;
        if (rightSpeed > 50)
        {
            rightSpeed = 50;
        }
        else if (rightSpeed < -50)
        {
            rightSpeed = -50;
        }
    }
    public void DisableRight()
    {
        Debug.Log("Right has been disabled");
        rightdisabled = true;
        chenilledroite.SetActive(true);
        rightSpeed = 0;
        if (leftSpeed > 50)
        {
            leftSpeed = 50;
        }
        else if (leftSpeed < -50)
        {
            leftSpeed = -50;
        }
    }

    private void EngineAudio()
    {
        // If there is no input (the tank is stationary)...
        if (Mathf.Abs(engine.velocity.x)<0.2 && Mathf.Abs(engine.velocity.y) < 0.2 && Mathf.Abs(engine.velocity.z) < 0.2)
        {
            // ... and if the audio source is currently playing the driving clip...
            if (m_MovementAudio.clip == m_EngineDriving)
            {
                // ... change the clip to idling and play it.
                m_MovementAudio.clip = m_EngineIdling;
                m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                m_MovementAudio.Play();
            }
        }
        else
        {
            // Otherwise if the tank is moving and if the idling clip is currently playing...
            if (m_MovementAudio.clip == m_EngineIdling)
            {
                // ... change the clip to driving and play.
                m_MovementAudio.clip = m_EngineDriving;
                m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                m_MovementAudio.Play();
            }
        }
    }
}
