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
        // remove lives
        app.model.lives.lives -= 1;
        CheckDeath();
        // invoke event
        app.view.lives.PlayerHit();
    }

    public void CheckDeath()
    {
        if (app.model.lives.lives > 0)
        {
            return;
        }

        // player died
        Debug.Log("Player died");
        PlayerHitEvents.playerDeathEvent.Invoke();
    }
}
