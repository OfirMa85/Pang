public class PlayerAttackingState : PlayerBaseState
{
    private readonly string stateName = "attacking";
    public override void OnEnter(PlayerStateController player)
    {
        player.app.view.player.anim.PlayAnimation(stateName);

        player.app.controller.attacks.SpawnAttack();
    }

    public override void OnAnimationEnd(PlayerStateController player)
    {
        // re-enter attack state
        if (player.app.controller.player.HandlePlayerAttacking())
        {
            return;
        }
        // change to idle
        player.ChangeState(player.idleState);
    }
}
