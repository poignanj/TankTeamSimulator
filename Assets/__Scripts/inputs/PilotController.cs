using UnityEngine;
using UnityEngine.Experimental.Input;


public class PilotController : MonoBehaviour, IPilotTankActions
{
    [SerializeField] private InputMaster inputMaster;
    [SerializeField] public Transform leftTrack, rightTrack;
    [Space][SerializeField] private float leftSpeed = 0, rightSpeed = 0;
    private Rigidbody engine;
    private void Awake()
    {
        inputMaster.PilotTank.SetCallbacks(this);
        engine = this.GetComponent<Rigidbody>();
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
        engine.AddForceAtPosition(this.transform.forward.normalized * rightSpeed, rightTrack.position);
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

}
