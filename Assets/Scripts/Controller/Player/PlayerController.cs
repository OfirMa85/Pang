using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : PangElement
{
    public PlayerInputController input;
    public PlayerStateController state;
    public PlayerAttacksController attacks;

    public void HandlePlayerMovement()
    {
        if (app.model.player.input.ismovingRight)
        {
            app.view.player.MovePlayer(Vector3.right);
        }
        else if (app.model.player.input.ismovingLeft)
        {
            app.view.player.MovePlayer(Vector3.left);
        }
    }

    public void HandlePlayerAttacking()
    {
        if (app.model.player.input.isAttacking)
        {
            state.ChangeState(state.attackingState);
        }
    }
    public void InitializeAttack()
    {
        attacks.SpawnAttack();
    }
}
