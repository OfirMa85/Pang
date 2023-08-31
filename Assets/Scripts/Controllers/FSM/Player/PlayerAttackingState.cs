public class PlayerAttackingState : PlayerBaseState
{
    private readonly string stateName = "attacking";
    public override void OnEnter(PlayerStateController player)
    {
        player.app.view.player.ChangeAnimation(stateName);

        player.app.controller.player.InitializeAttack();
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
