using System.Collections;
using UnityEngine;

public class Player : Entity
{

    public bool isBusy { get; private set; }

    [Header("Move info")]
    public float moveSpeed = 5f;

    [HideInInspector] public bool canInteract;

    public PlayerStateMachine stateMachine { get; private set; }
    public PlayerIdleState idleState { get; private set; }
    public PlayerMoveState moveState { get; private set; }
    public PlayerInteractState interactState { get; private set; }


    protected override void Awake()
    {
        base.Awake();
        stateMachine = new PlayerStateMachine();

        idleState = new PlayerIdleState(this, stateMachine, "Idle");
        moveState = new PlayerMoveState(this, stateMachine, "Move");
        interactState = new PlayerInteractState(this, stateMachine, "Interact");

    }

    protected override void Start()
    {
        base.Start();

        stateMachine.Initialized(idleState);

    }

    protected override void Update()
    {
        base.Update();
        stateMachine.currentState.Update();

    }

    public IEnumerator BusyFor(float _seconds)
    {
        isBusy = true;

        yield return new WaitForSeconds(_seconds);

        isBusy = false;
    }

    public void AnimationTrigger() => stateMachine.currentState.AnimationFinishTrigger();
}



