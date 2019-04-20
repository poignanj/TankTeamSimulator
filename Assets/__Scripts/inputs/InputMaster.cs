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
        m_PilotTank_StopLeft = m_PilotTank.GetAction("Stop Left");
        if (m_PilotTankStopLeftActionStarted != null)
            m_PilotTank_StopLeft.started += m_PilotTankStopLeftActionStarted.Invoke;
        if (m_PilotTankStopLeftActionPerformed != null)
            m_PilotTank_StopLeft.performed += m_PilotTankStopLeftActionPerformed.Invoke;
        if (m_PilotTankStopLeftActionCancelled != null)
            m_PilotTank_StopLeft.cancelled += m_PilotTankStopLeftActionCancelled.Invoke;
        m_PilotTank_StopRight = m_PilotTank.GetAction("Stop Right");
        if (m_PilotTankStopRightActionStarted != null)
            m_PilotTank_StopRight.started += m_PilotTankStopRightActionStarted.Invoke;
        if (m_PilotTankStopRightActionPerformed != null)
            m_PilotTank_StopRight.performed += m_PilotTankStopRightActionPerformed.Invoke;
        if (m_PilotTankStopRightActionCancelled != null)
            m_PilotTank_StopRight.cancelled += m_PilotTankStopRightActionCancelled.Invoke;
        m_PilotTank_StopAll = m_PilotTank.GetAction("Stop All");
        if (m_PilotTankStopAllActionStarted != null)
            m_PilotTank_StopAll.started += m_PilotTankStopAllActionStarted.Invoke;
        if (m_PilotTankStopAllActionPerformed != null)
            m_PilotTank_StopAll.performed += m_PilotTankStopAllActionPerformed.Invoke;
        if (m_PilotTankStopAllActionCancelled != null)
            m_PilotTank_StopAll.cancelled += m_PilotTankStopAllActionCancelled.Invoke;
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
        m_Artillery_Fire = m_Artillery.GetAction("Fire");
        if (m_ArtilleryFireActionStarted != null)
            m_Artillery_Fire.started += m_ArtilleryFireActionStarted.Invoke;
        if (m_ArtilleryFireActionPerformed != null)
            m_Artillery_Fire.performed += m_ArtilleryFireActionPerformed.Invoke;
        if (m_ArtilleryFireActionCancelled != null)
            m_Artillery_Fire.cancelled += m_ArtilleryFireActionCancelled.Invoke;
        m_Artillery_Reload = m_Artillery.GetAction("Reload");
        if (m_ArtilleryReloadActionStarted != null)
            m_Artillery_Reload.started += m_ArtilleryReloadActionStarted.Invoke;
        if (m_ArtilleryReloadActionPerformed != null)
            m_Artillery_Reload.performed += m_ArtilleryReloadActionPerformed.Invoke;
        if (m_ArtilleryReloadActionCancelled != null)
            m_Artillery_Reload.cancelled += m_ArtilleryReloadActionCancelled.Invoke;
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
        m_PilotTank_StopLeft = null;
        if (m_PilotTankStopLeftActionStarted != null)
            m_PilotTank_StopLeft.started -= m_PilotTankStopLeftActionStarted.Invoke;
        if (m_PilotTankStopLeftActionPerformed != null)
            m_PilotTank_StopLeft.performed -= m_PilotTankStopLeftActionPerformed.Invoke;
        if (m_PilotTankStopLeftActionCancelled != null)
            m_PilotTank_StopLeft.cancelled -= m_PilotTankStopLeftActionCancelled.Invoke;
        m_PilotTank_StopRight = null;
        if (m_PilotTankStopRightActionStarted != null)
            m_PilotTank_StopRight.started -= m_PilotTankStopRightActionStarted.Invoke;
        if (m_PilotTankStopRightActionPerformed != null)
            m_PilotTank_StopRight.performed -= m_PilotTankStopRightActionPerformed.Invoke;
        if (m_PilotTankStopRightActionCancelled != null)
            m_PilotTank_StopRight.cancelled -= m_PilotTankStopRightActionCancelled.Invoke;
        m_PilotTank_StopAll = null;
        if (m_PilotTankStopAllActionStarted != null)
            m_PilotTank_StopAll.started -= m_PilotTankStopAllActionStarted.Invoke;
        if (m_PilotTankStopAllActionPerformed != null)
            m_PilotTank_StopAll.performed -= m_PilotTankStopAllActionPerformed.Invoke;
        if (m_PilotTankStopAllActionCancelled != null)
            m_PilotTank_StopAll.cancelled -= m_PilotTankStopAllActionCancelled.Invoke;
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
        m_Artillery_Fire = null;
        if (m_ArtilleryFireActionStarted != null)
            m_Artillery_Fire.started -= m_ArtilleryFireActionStarted.Invoke;
        if (m_ArtilleryFireActionPerformed != null)
            m_Artillery_Fire.performed -= m_ArtilleryFireActionPerformed.Invoke;
        if (m_ArtilleryFireActionCancelled != null)
            m_Artillery_Fire.cancelled -= m_ArtilleryFireActionCancelled.Invoke;
        m_Artillery_Reload = null;
        if (m_ArtilleryReloadActionStarted != null)
            m_Artillery_Reload.started -= m_ArtilleryReloadActionStarted.Invoke;
        if (m_ArtilleryReloadActionPerformed != null)
            m_Artillery_Reload.performed -= m_ArtilleryReloadActionPerformed.Invoke;
        if (m_ArtilleryReloadActionCancelled != null)
            m_Artillery_Reload.cancelled -= m_ArtilleryReloadActionCancelled.Invoke;
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
    private InputAction m_PilotTank_StopLeft;
    [SerializeField] private ActionEvent m_PilotTankStopLeftActionStarted;
    [SerializeField] private ActionEvent m_PilotTankStopLeftActionPerformed;
    [SerializeField] private ActionEvent m_PilotTankStopLeftActionCancelled;
    private InputAction m_PilotTank_StopRight;
    [SerializeField] private ActionEvent m_PilotTankStopRightActionStarted;
    [SerializeField] private ActionEvent m_PilotTankStopRightActionPerformed;
    [SerializeField] private ActionEvent m_PilotTankStopRightActionCancelled;
    private InputAction m_PilotTank_StopAll;
    [SerializeField] private ActionEvent m_PilotTankStopAllActionStarted;
    [SerializeField] private ActionEvent m_PilotTankStopAllActionPerformed;
    [SerializeField] private ActionEvent m_PilotTankStopAllActionCancelled;
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
        public InputAction @StopLeft { get { return m_Wrapper.m_PilotTank_StopLeft; } }
        public ActionEvent StopLeftStarted { get { return m_Wrapper.m_PilotTankStopLeftActionStarted; } }
        public ActionEvent StopLeftPerformed { get { return m_Wrapper.m_PilotTankStopLeftActionPerformed; } }
        public ActionEvent StopLeftCancelled { get { return m_Wrapper.m_PilotTankStopLeftActionCancelled; } }
        public InputAction @StopRight { get { return m_Wrapper.m_PilotTank_StopRight; } }
        public ActionEvent StopRightStarted { get { return m_Wrapper.m_PilotTankStopRightActionStarted; } }
        public ActionEvent StopRightPerformed { get { return m_Wrapper.m_PilotTankStopRightActionPerformed; } }
        public ActionEvent StopRightCancelled { get { return m_Wrapper.m_PilotTankStopRightActionCancelled; } }
        public InputAction @StopAll { get { return m_Wrapper.m_PilotTank_StopAll; } }
        public ActionEvent StopAllStarted { get { return m_Wrapper.m_PilotTankStopAllActionStarted; } }
        public ActionEvent StopAllPerformed { get { return m_Wrapper.m_PilotTankStopAllActionPerformed; } }
        public ActionEvent StopAllCancelled { get { return m_Wrapper.m_PilotTankStopAllActionCancelled; } }
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
                StopLeft.started -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnStopLeft;
                StopLeft.performed -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnStopLeft;
                StopLeft.cancelled -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnStopLeft;
                StopRight.started -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnStopRight;
                StopRight.performed -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnStopRight;
                StopRight.cancelled -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnStopRight;
                StopAll.started -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnStopAll;
                StopAll.performed -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnStopAll;
                StopAll.cancelled -= m_Wrapper.m_PilotTankActionsCallbackInterface.OnStopAll;
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
                StopLeft.started += instance.OnStopLeft;
                StopLeft.performed += instance.OnStopLeft;
                StopLeft.cancelled += instance.OnStopLeft;
                StopRight.started += instance.OnStopRight;
                StopRight.performed += instance.OnStopRight;
                StopRight.cancelled += instance.OnStopRight;
                StopAll.started += instance.OnStopAll;
                StopAll.performed += instance.OnStopAll;
                StopAll.cancelled += instance.OnStopAll;
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
    private InputAction m_Artillery_Fire;
    [SerializeField] private ActionEvent m_ArtilleryFireActionStarted;
    [SerializeField] private ActionEvent m_ArtilleryFireActionPerformed;
    [SerializeField] private ActionEvent m_ArtilleryFireActionCancelled;
    private InputAction m_Artillery_Reload;
    [SerializeField] private ActionEvent m_ArtilleryReloadActionStarted;
    [SerializeField] private ActionEvent m_ArtilleryReloadActionPerformed;
    [SerializeField] private ActionEvent m_ArtilleryReloadActionCancelled;
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
        public InputAction @Fire { get { return m_Wrapper.m_Artillery_Fire; } }
        public ActionEvent FireStarted { get { return m_Wrapper.m_ArtilleryFireActionStarted; } }
        public ActionEvent FirePerformed { get { return m_Wrapper.m_ArtilleryFireActionPerformed; } }
        public ActionEvent FireCancelled { get { return m_Wrapper.m_ArtilleryFireActionCancelled; } }
        public InputAction @Reload { get { return m_Wrapper.m_Artillery_Reload; } }
        public ActionEvent ReloadStarted { get { return m_Wrapper.m_ArtilleryReloadActionStarted; } }
        public ActionEvent ReloadPerformed { get { return m_Wrapper.m_ArtilleryReloadActionPerformed; } }
        public ActionEvent ReloadCancelled { get { return m_Wrapper.m_ArtilleryReloadActionCancelled; } }
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
                Fire.started -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnFire;
                Fire.performed -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnFire;
                Fire.cancelled -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnFire;
                Reload.started -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnReload;
                Reload.performed -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnReload;
                Reload.cancelled -= m_Wrapper.m_ArtilleryActionsCallbackInterface.OnReload;
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
                Fire.started += instance.OnFire;
                Fire.performed += instance.OnFire;
                Fire.cancelled += instance.OnFire;
                Reload.started += instance.OnReload;
                Reload.performed += instance.OnReload;
                Reload.cancelled += instance.OnReload;
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
    void OnStopLeft(InputAction.CallbackContext context);
    void OnStopRight(InputAction.CallbackContext context);
    void OnStopAll(InputAction.CallbackContext context);
}
public interface IChiefControlsActions
{
    void OnClick(InputAction.CallbackContext context);
}
public interface IArtilleryActions
{
    void OnRotateY(InputAction.CallbackContext context);
    void OnRotateX(InputAction.CallbackContext context);
    void OnFire(InputAction.CallbackContext context);
    void OnReload(InputAction.CallbackContext context);
}
