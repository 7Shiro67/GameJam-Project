using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevel;

public class PlayerInteractState : PlayerGroundedState
{
    public PlayerInteractState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
        
    }

    public override void Enter()
    {
        base.Enter();
        player.rb.constraints = RigidbodyConstraints2D.FreezeAll;
        player.SetZeroVelocity();
    }

    public override void Exit()
    {
        base.Exit();
        player.rb.constraints = RigidbodyConstraints2D.None;
        player.rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public override void Update()
    {
        base.Update();
        if(Input.GetKeyDown(KeyCode.Q))
        {
            stateMachine.ChangeState(player.idleState);
        }
    }
}
