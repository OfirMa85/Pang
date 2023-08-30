using UnityEngine;

public class PlayerAttackingState : PlayerBaseState
{
    private readonly string stateName = "attacking";
    public override void OnEnter(PlayerStateController player)
    {
        player.app.view.player.anim.PlayAnimation(stateName);

        player.app.controller.player.InitializeAttack();
    }

    public override void OnAnimationEnd(PlayerStateController player)
    {
        // re-enter attack state
        if (player.app.model.player.input.isAttacking)
        {
            player.ChangeState(player.attackingState);
        }
        else // change to idle state
        {
            player.ChangeState(player.idleState);
        }
    }
}
