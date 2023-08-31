using UnityEngine;

public class PlayerController : PangElement
{
    public PlayerStateController state;
    public PlayerAttacksController attacks;

    public void HandlePlayerMovement()
    {
        if (GameModel.IsPaused())
        {
            return;
        }

        // get x movement
        float xAxis = app.model.input.GetAxis(Axis.X);
        if (xAxis == 0)
        {
            return;
        }
        // move player
        app.view.player.MovePlayer(Mathf.Sign(xAxis) * Vector3.right);
    }

    public bool HandlePlayerAttacking()
    {
        if (GameModel.IsPaused())
        {
            return false;
        }

        if (app.model.input.GetActionPressed(InputAction.Attack))
        {
            state.ChangeState(state.attackingState);
            return true;
        }
        return false;
    }
    public void InitializeAttack()
    {
        attacks.SpawnAttack();
    }
}
