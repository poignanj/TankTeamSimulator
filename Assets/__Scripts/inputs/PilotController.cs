﻿using UnityEngine;
using UnityEngine.Experimental.Input;


public class PilotController : MonoBehaviour, IPilotTankActions
{

    public AudioSource m_MovementAudio;         // Reference to the audio source used to play engine sounds. NB: different to the shooting audio source.
    public AudioClip m_EngineIdling;            // Audio to play when the tank isn't moving.
    public AudioClip m_EngineDriving;           // Audio to play when the tank is moving.
    private float m_OriginalPitch;              // The pitch of the audio source at the start of the scene.
    public float m_PitchRange = 0.2f;           // The amount by which the pitch of the engine noises can vary.


    [SerializeField] private InputMaster inputMaster;
    [SerializeField] public Transform leftTrack, rightTrack;
    [Space][SerializeField] private float leftSpeed = 0, rightSpeed = 0;
    private Rigidbody engine;
    private void Awake()
    {
        inputMaster.PilotTank.SetCallbacks(this);
        engine = this.GetComponent<Rigidbody>();
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
        //todo: Adjust speed scaling (percentile?)
        engine.velocity.Set(0, 0, 0);
        engine.AddForceAtPosition(this.transform.forward.normalized * leftSpeed, leftTrack.position);
        engine.AddForceAtPosition(this.transform.forward.normalized * rightSpeed, rightTrack.position);            EngineAudio ();
        EngineAudio();
    }

    public void OnMoveLeftLever(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<float>();
        leftSpeed += direction;
    }

    public void OnMoveRightLever(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<float>();
        rightSpeed += direction;
    }


    private void EngineAudio()
    {
        Debug.Log(engine.velocity);
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
