using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class ArtilleryController : MonoBehaviour, IArtilleryActions
{

    public AudioSource m_shootingAudio;
    public AudioClip m_FireClip;
    public AudioClip m_ReloadClip;
    public Transform m_FireTransform;
    public Rigidbody m_Shell;
    public float firepower = 30;

    [SerializeField] private InputMaster inputMaster;
    [SerializeField] private Transform turret, barrel;
    private float turnIncrement = 0, aimIncrement = 0;
    private bool readyToFire = true;

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
        if(barrel.transform.localEulerAngles.x + aimIncrement < 15 || barrel.transform.localEulerAngles.x + aimIncrement > 340)
            barrel.transform.Rotate(new Vector3(1, 0, 0), aimIncrement);
    }
    public void OnRotateX(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        //Warning: Calculate rotation first (stick from gamepad)
        turnIncrement = direction[0];
    }

    public void OnRotateY(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        //Warning: Calculate rotation first (stick from gamepad)
        aimIncrement = direction[1];
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if (readyToFire)
        {
           Fire();
        }
    }

    public void OnReload(InputAction.CallbackContext context)
    {
        if (!readyToFire)
        {
            readyToFire = true;
            m_shootingAudio.clip = m_ReloadClip;
            m_shootingAudio.Play();
        }
    }

    private void Fire()
    {
        readyToFire = false;
        Rigidbody shellInstance = Instantiate(m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

        shellInstance.velocity = m_FireTransform.up*firepower*-1;
        m_shootingAudio.clip = m_FireClip;
        m_shootingAudio.Play();
    }
}
