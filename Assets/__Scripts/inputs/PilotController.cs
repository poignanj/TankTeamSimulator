using UnityEngine;
using UnityEngine.Experimental.Input;


public class PilotController : MonoBehaviour, IPilotTankActions
{
    [SerializeField] private InputMaster inputMaster;

    //Todo: Get both engines
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
        Vector3 worldForcePositionLeft = transform.TransformPoint(leftTrack.position);
        Vector3 worldForcePositionRight = transform.TransformPoint(rightTrack.position);
        engine.AddForceAtPosition(this.transform.forward.normalized*leftSpeed, worldForcePositionLeft);
        engine.AddForceAtPosition(this.transform.forward.normalized*rightSpeed, worldForcePositionRight);
    }

    public void OnMoveLeftLever(InputAction.CallbackContext context)
    {
        //Todo: Add speed to Left Trail
        var direction = context.ReadValue<float>();
        Debug.Log("Left : " + direction); //aff0
        leftSpeed += direction;
    }

    public void OnMoveRightLever(InputAction.CallbackContext context)
    {
        //Todo: Add speed to Right Trail
        var direction = context.ReadValue<float>();
        Debug.Log("Right : " + direction); //aff0
        rightSpeed += direction;
    }

}
