public class PlayerIdleState : PlayerBaseState
{
    private readonly string stateName = "idle";
    public override void OnEnter(PlayerStateController player)
    {
        player.app.view.player.ChangeAnimation(stateName);
    }

    public override void OnUpdate(PlayerStateController player)
    {
        // try attacking
        player.app.controller.player.HandlePlayerAttacking();

        // try moving
        if (player.app.model.input.GetAxis(Axis.X) != 0)
        {
            player.ChangeState(player.movingState);
        }
    }
}
