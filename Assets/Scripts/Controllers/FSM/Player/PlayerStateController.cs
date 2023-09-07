using UnityEngine;

public class PlayerStateController : PangElement
{
    public PlayerIdleState idleState = new();
    public PlayerMovingState movingState = new();
    public PlayerAttackingState attackingState = new();

    private void Start()
    {
        ChangeState(idleState);
    }

    private void Update()
    {
        if (app.model.pause.IsPaused())
        {
            return;
        }

        app.model.player.currentState?.OnUpdate(this);
    }

    public void ChangeState(PlayerBaseState state)
    {
        app.model.player.currentState?.OnExit(this);
        app.model.player.currentState = state;
        state.OnEnter(this);
    }
}
