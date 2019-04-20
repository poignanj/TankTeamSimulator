// GENERATED AUTOMATICALLY FROM 'Assets/__Assets/InputMaster.inputactions'

using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Input;


[Serializable]
public class InputMaster : InputActionAssetReference
{
    public InputMaster()
    {
    }
    public InputMaster(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // PilotTank
        m_PilotTank = asset.GetActionMap("PilotTank");
        m_PilotTank_MoveRightLever = m_PilotTank.GetAction("MoveRightLever");
        if (m_PilotTankMoveRightLeverActionStarted != null)
            m_PilotTank_MoveRightLever.started += m_PilotTankMoveRightLeverActionStarted.Invoke;
        if (m_PilotTankMoveRightLeverActionPerformed != null)
            m_PilotTank_MoveRightLever.performed += m_PilotTankMoveRightLeverActionPerformed.Invoke;
        if (m_PilotTankMoveRightLeverActionCancelled != null)
            m_PilotTank_MoveRightLever.cancelled += m_PilotTankMoveRightLeverActionCancelled.Invoke;
        m_PilotTank_MoveLeftLever = m_PilotTank.GetAction("MoveLeftLever");
        if (m_PilotTankMoveLeftLeverActionStarted != null)
            m_PilotTank_MoveLeftLever.started += m_PilotTankMoveLeftLeverActionStarted.Invoke;
        if (m_PilotTankMoveLeftLeverActionPerformed != null)
            m_PilotTank_MoveLeftLever.performed += m_PilotTankMoveLeftLeverActionPerformed.Invoke;
        if (m_PilotTankMoveLeftLeverActionCancelled != null)
            m_PilotTank_MoveLeftLever.cancelled += m_PilotTankMoveLeftLeverActionCancelled.Invoke;
        // ChiefControls
        m_ChiefControls = asset.GetActionMap("ChiefControls");
        m_ChiefControls_Click = m_ChiefControls.GetAction("Click");
        if (m_ChiefControlsClickActionStarted != null)
            m_ChiefControls_Click.started += m_ChiefControlsClickActionStarted.Invoke;
        if (m_ChiefControlsClickActionPerformed != null)
            m_ChiefControls_Click.performed += m_ChiefControlsClickActionPerformed.Invoke;
        if (m_ChiefControlsClickActionCancelled != null)
            m_ChiefControls_Click.cancelled += m_ChiefControlsClickActionCancelled.Invoke;
        // Artillery
        m_Artillery = asset.GetActionMap("Artillery");
        m_Artillery_RotateY = m_Artillery.GetAction("RotateY");
        if (m_ArtilleryRotateYActionStarted != null)
            m_Artillery_RotateY.started += m_ArtilleryRotateYActionStarted.Invoke;
        if (m_ArtilleryRotateYActionPerformed != null)
            m_Artillery_RotateY.performed += m_ArtilleryRotateYActionPerformed.Invoke;
        if (m_ArtilleryRotateYActionCancelled != null)
            m_Artillery_RotateY.cancelled += m_ArtilleryRotateYActionCancelled.Invoke;
        m_Artillery_RotateX = m_Artillery.GetAction("RotateX");
        if (m_ArtilleryRotateXActionStarted != null)
            m_Artillery_RotateX.started += m_ArtilleryRotateXActionStarted.Invoke;
        if (m_ArtilleryRotateXActionPerformed != null)
            m_Artillery_RotateX.performed += m_ArtilleryRotateXActionPerformed.Invoke;
        if (m_ArtilleryRotateXActionCancelled != null)
            m_Artillery_RotateX.cancelled += m_ArtilleryRotateXActionCancelled.Invoke;
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        if (m_PilotTankActionsCallbackInterface != null)
        {
            PilotTank.SetCallbacks(null);
        }
        m_PilotTank = null;
        m_PilotTank_MoveRightLever = null;
        if (m_PilotTankMoveRightLeverActionStarted != null)
            m_PilotTank_MoveRightLever.started -= m_PilotTankMoveRightLeverActionStarted.Invoke;
        if (m_PilotTankMoveRightLeverActionPerformed != null)
            m_PilotTank_MoveRightLever.performed -= m_PilotTankMoveRightLeverActionPerformed.Invoke;
        if (m_PilotTankMoveRightLeverActionCancelled != null)
            m_PilotTank_MoveRightLever.cancelled -= m_PilotTankMoveRightLeverActionCancelled.Invoke;
        m_PilotTank_MoveLeftLever = null;
        if (m_PilotTankMoveLeftLeverActionStarted != null)
            m_PilotTank_MoveLeftLever.started -= m_PilotTankMoveLeftLeverActionStarted.Invoke;
        if (m_PilotTankMoveLeftLeverActionPerformed != null)
            m_PilotTank_MoveLeftLever.performed -= m_PilotTankMoveLeftLeverActionPerformed.Invoke;
        if (m_PilotTankMoveLeftLeverActionCancelled != null)
            m_PilotTank_MoveLeftLever.cancelled -= m_PilotTankMoveLeftLeverActionCancelled.Invoke;
        if (m_ChiefControlsActionsCallbackInterface != null)
        {
            ChiefControls.SetCallbacks(null);
        }
        m_ChiefControls = null;
        m_ChiefControls_Click = null;
        if (m_ChiefControlsClickActionStarted != null)
            m_ChiefControls_Click.started -= m_ChiefControlsClickActionStarted.Invoke;
        if (m_ChiefControlsClickActionPerformed != null)
            m_ChiefControls_Click.performed -= m_ChiefControlsClickActionPerformed.Invoke;
        if (m_ChiefControlsClickActionCancelled != null)
            m_ChiefControls_Click.cancelled -= m_ChiefControlsClickActionCancelled.Invoke;
        if (m_ArtilleryActionsCallbackInterface != null)
        {
            Artillery.SetCallbacks(null);
        }
        m_Artillery = null;
        m_Artillery_RotateY = null;
        if (m_ArtilleryRotateYActionStarted != null)
            m_Artillery_RotateY.started -= m_ArtilleryRotateYActionStarted.Invoke;
        if (m_ArtilleryRotateYActionPerformed != null)
            m_Artillery_RotateY.performed -= m_ArtilleryRotateYActionPerformed.Invoke;
        if (m_ArtilleryRotateYActionCancelled != null)
            m_Artillery_RotateY.cancelled -= m_ArtilleryRotateYActionCancelled.Invoke;
        m_Artillery_RotateX = null;
        if (m_ArtilleryRotateXActionStarted != null)
            m_Artillery_RotateX.started -= m_ArtilleryRotateXActionStarted.Invoke;
        if (m_ArtilleryRotateXActionPerformed != null)
            m_Artillery_RotateX.performed -= m_ArtilleryRotateXActionPerformed.Invoke;
        if (m_ArtilleryRotateXActionCancelled != null)
            m_Artillery_RotateX.cancelled -= m_ArtilleryRotateXActionCancelled.Invoke;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        var PilotTankCallbacks = m_PilotTankActionsCallbackInterface;
        var ChiefControlsCallbacks = m_ChiefControlsActionsCallbackInterface;
        var ArtilleryCallbacks = m_ArtilleryActionsCallbackInterface;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
        PilotTank.SetCallbacks(PilotTankCallbacks);
        ChiefControls.SetCallbacks(ChiefControlsCallbacks);
        Artillery.SetCallbacks(ArtilleryCallbacks);
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // PilotTank
    private InputActionMap m_PilotTank;
    private IPilotTankActions m_PilotTankActionsCallbackInterface;
    private InputAction m_PilotTank_MoveRightLever;
    [SerializeField] private ActionEvent m_PilotTankMoveRightLeverActionStarted;
    [SerializeField] private ActionEvent m_PilotTankMoveRightLeverActionPerformed;
    [SerializeField] private ActionEvent m_PilotTankMoveRightLeverActionCancelled;
    private InputAction m_PilotTank_MoveLeftLever;
    [SerializeField] private ActionEvent m_PilotTankMoveLeftLeverActionStarted;
    [SerializeField] private ActionEvent m_PilotTankMoveLeftLeverActionPerformed;
    [SerializeField] private ActionEvent m_PilotTankMoveLeftLeverActionCancelled;
    public struct PilotTankActions
    {
        private InputMaster m_Wrapper;
        public PilotTankActions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveRightLever { get { return m_Wrapper.m_PilotTank_MoveRightLever; } }
        public ActionEvent MoveRightLeverStarted { get { return m_Wrapper.m_PilotTankMoveRightLeverActionStarted; } }
        public ActionEvent MoveRightLeverPerformed { get { return m_Wrapper.m_PilotTankMoveRightLeverActionPerformed; } }
        public ActionEvent MoveRightLeverCancelled { get { return m_Wrapper.m_PilotTankMoveRightLeverActionCancelled; } }
        public InputAction @MoveLeftLever { get { return m_Wrapper.m_PilotTank_MoveLeftLever; } }
        public ActionEvent MoveLeftLeverStarted { get { return m_Wrapper.m_PilotTankMoveLeftLeverActionStarted; } }
        public ActionEvent MoveLeftLeverPerformed { get { return m_Wrapper.m_PilotTankMoveLeftLeverActionPerformed; } }
        public ActionEvent MoveLeftLeverCancelled { get { return m_Wrapper.m_PilotTankMoveLeftLeverActionCancelled; } }
        public InputActionMap Get() { return m_Wrapper.m_PilotTank; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(PilotTankActions set) { return set.Get(); }
        public void SetCallbacks(IPilotTankActions instance)
        {
            if (m_Wrapper.m_PilotTankActionsCallbackInterface != null)
            {
                MoveRightLever.started -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnMoveRightLever;
                MoveRightLever.performed -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnMoveRightLever;
                MoveRightLever.cancelled -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnMoveRightLever;
                MoveLeftLever.started -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnMoveLeftLever;
                MoveLeftLever.performed -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnMoveLeftLever;
                MoveLeftLever.cancelled -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnMoveLeftLever;
            }
            m_Wrapper.m_PilotTankActionsCallbackInterface = instance;
            if (instance != null)
            {
                MoveRightLever.started += instance.OnMoveRightLever;
                MoveRightLever.performed += instance.OnMoveRightLever;
                MoveRightLever.cancelled += instance.OnMoveRightLever;
                MoveLeftLever.started += instance.OnMoveLeftLever;
                MoveLeftLever.performed += instance.OnMoveLeftLever;
                MoveLeftLever.cancelled += instance.OnMoveLeftLever;
            }
        }
    }
    public PilotTankActions @PilotTank
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new PilotTankActions(this);
        }
    }
    // ChiefControls
    private InputActionMap m_ChiefControls;
    private IChiefControlsActions m_ChiefControlsActionsCallbackInterface;
    private InputAction m_ChiefControls_Click;
    [SerializeField] private ActionEvent m_ChiefControlsClickActionStarted;
    [SerializeField] private ActionEvent m_ChiefControlsClickActionPerformed;
    [SerializeField] private ActionEvent m_ChiefControlsClickActionCancelled;
    public struct ChiefControlsActions
    {
        private InputMaster m_Wrapper;
        public ChiefControlsActions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click { get { return m_Wrapper.m_ChiefControls_Click; } }
        public ActionEvent ClickStarted { get { return m_Wrapper.m_ChiefControlsClickActionStarted; } }
        public ActionEvent ClickPerformed { get { return m_Wrapper.m_ChiefControlsClickActionPerformed; } }
        public ActionEvent ClickCancelled { get { return m_Wrapper.m_ChiefControlsClickActionCancelled; } }
        public InputActionMap Get() { return m_Wrapper.m_ChiefControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(ChiefControlsActions set) { return set.Get(); }
        public void SetCallbacks(IChiefControlsActions instance)
        {
            if (m_Wrapper.m_ChiefControlsActionsCallbackInterface != null)
            {
                Click.started -= m_Wrapper.m_ChiefControlsActionsCallbackInterface.OnClick;
                Click.performed -= m_Wrapper.m_ChiefControlsActionsCallbackInterface.OnClick;
                Click.cancelled -= m_Wrapper.m_ChiefControlsActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_ChiefControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                Click.started += instance.OnClick;
                Click.performed += instance.OnClick;
                Click.cancelled += instance.OnClick;
            }
        }
    }
    public ChiefControlsActions @ChiefControls
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new ChiefControlsActions(this);
        }
    }
    // Artillery
    private InputActionMap m_Artillery;
    private IArtilleryActions m_ArtilleryActionsCallbackInterface;
    private InputAction m_Artillery_RotateY;
    [SerializeField] private ActionEvent m_ArtilleryRotateYActionStarted;
    [SerializeField] private ActionEvent m_ArtilleryRotateYActionPerformed;
    [SerializeField] private ActionEvent m_ArtilleryRotateYActionCancelled;
    private InputAction m_Artillery_RotateX;
    [SerializeField] private ActionEvent m_ArtilleryRotateXActionStarted;
    [SerializeField] private ActionEvent m_ArtilleryRotateXActionPerformed;
    [SerializeField] private ActionEvent m_ArtilleryRotateXActionCancelled;
    public struct ArtilleryActions
    {
        private InputMaster m_Wrapper;
        public ArtilleryActions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateY { get { return m_Wrapper.m_Artillery_RotateY; } }
        public ActionEvent RotateYStarted { get { return m_Wrapper.m_ArtilleryRotateYActionStarted; } }
        public ActionEvent RotateYPerformed { get { return m_Wrapper.m_ArtilleryRotateYActionPerformed; } }
        public ActionEvent RotateYCancelled { get { return m_Wrapper.m_ArtilleryRotateYActionCancelled; } }
        public InputAction @RotateX { get { return m_Wrapper.m_Artillery_RotateX; } }
        public ActionEvent RotateXStarted { get { return m_Wrapper.m_ArtilleryRotateXActionStarted; } }
        public ActionEvent RotateXPerformed { get { return m_Wrapper.m_ArtilleryRotateXActionPerformed; } }
        public ActionEvent RotateXCancelled { get { return m_Wrapper.m_ArtilleryRotateXActionCancelled; } }
        public InputActionMap Get() { return m_Wrapper.m_Artillery; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(ArtilleryActions set) { return set.Get(); }
        public void SetCallbacks(IArtilleryActions instance)
        {
            if (m_Wrapper.m_ArtilleryActionsCallbackInterface != null)
            {
                RotateY.started -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnRotateY;
                RotateY.performed -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnRotateY;
                RotateY.cancelled -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnRotateY;
                RotateX.started -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnRotateX;
                RotateX.performed -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnRotateX;
                RotateX.cancelled -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnRotateX;
            }
            m_Wrapper.m_ArtilleryActionsCallbackInterface = instance;
            if (instance != null)
            {
                RotateY.started += instance.OnRotateY;
                RotateY.performed += instance.OnRotateY;
                RotateY.cancelled += instance.OnRotateY;
                RotateX.started += instance.OnRotateX;
                RotateX.performed += instance.OnRotateX;
                RotateX.cancelled += instance.OnRotateX;
            }
        }
    }
    public ArtilleryActions @Artillery
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new ArtilleryActions(this);
        }
    }
    private int m_TankControlsSchemeIndex = -1;
    public InputControlScheme TankControlsScheme
    {
        get

        {
            if (m_TankControlsSchemeIndex == -1) m_TankControlsSchemeIndex = asset.GetControlSchemeIndex("TankControls");
            return asset.controlSchemes[m_TankControlsSchemeIndex];
        }
    }
    [Serializable]
    public class ActionEvent : UnityEvent<InputAction.CallbackContext>
    {
    }
}
public interface IPilotTankActions
{
    void OnMoveRightLever(InputAction.CallbackContext context);
    void OnMoveLeftLever(InputAction.CallbackContext context);
}
public interface IChiefControlsActions
{
    void OnClick(InputAction.CallbackContext context);
}
public interface IArtilleryActions
{
    void OnRotateY(InputAction.CallbackContext context);
    void OnRotateX(InputAction.CallbackContext context);
}
