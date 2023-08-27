public class PlayerMovingState : PlayerBaseState
{
    private readonly string stateName = "moving";
    public override void OnEnter(PlayerStateController player)
    {
        player.app.view.player.anim.PlayAnimation(stateName);
    }

    public override void OnUpdate(PlayerStateController player)
    {
        player.app.controller.player.HandlePlayerMovement();
        player.app.controller.player.HandlePlayerAttacking();

        if (!player.app.model.player.input.IsMoving)
        {
            player.ChangeState(player.idleState);
        }
    }
}
