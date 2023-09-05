using UnityEngine;

public class LivesController : PangElement
{
    private void Awake()
    {
        PlayerHitEvents.playerHitEvent.AddListener(PlayerHit);
        app.view.lives.InitializeHearts(app.model.lives.lives);
    }

    private void PlayerHit()
    {
        app.model.lives.lives -= 1;
        app.controller.player.CheckDeath();
        app.view.lives.PlayerHit();
    }
}
