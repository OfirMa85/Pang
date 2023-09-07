using System.Collections;
using UnityEngine;

public class PlayerController : PangElement
{
    public PlayerStateController state;

    private void Awake()
    {
        PlayerHitEvents.playerHitboxHitEvent.AddListener(OnHitboxHit);
    }

    public void HandlePlayerMovement()
    {
        if (app.model.pause.IsPaused())
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
        if (app.model.pause.IsPaused())
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

    private void OnHitboxHit(Collider2D collider)
    {
        // check for invincibility
        if (app.model.player.invincible)
        {
            return;
        }
        Debug.Log("Player got hit");

        // toggle invisibility
        ToggleInvincibility(true);
        StartCoroutine(InvincibilityDelay());

        // call event
        PlayerHitEvents.playerHitEvent.Invoke();
    }

    private IEnumerator InvincibilityDelay()
    {
        // delay
        yield return new WaitForSeconds(app.model.player.invincibilityDuration);

        ToggleInvincibility(false);
    }

    private void ToggleInvincibility(bool toggle)
    {
        app.model.player.invincible = toggle;
        app.view.player.anim.ToggleInvincibility(toggle);
    }
}
