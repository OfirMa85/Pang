using UnityEngine;

public class PlayerCollider : PangElement
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            PlayerHitEvents.playerHitboxHitEvent.Invoke(collision);
        }
    }
}
