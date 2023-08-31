public class PlayerMovingState : PlayerBaseState
{
    private readonly string stateName = "moving";
    public override void OnEnter(PlayerStateController player)
    {
        player.app.view.player.ChangeAnimation(stateName);
    }

    public override void OnUpdate(PlayerStateController player)
    {
        // change to attacking state
        if (player.app.controller.player.HandlePlayerAttacking())
        {
            return;
        }

        player.app.controller.player.HandlePlayerMovement();

        // stopped moving
        if (player.app.model.input.GetAxis(Axis.X) == 0)
        {
            player.ChangeState(player.idleState);
        }
    }
}
