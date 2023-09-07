using UnityEngine;
using UnityEngine.Events;

public class PlayerHitEvents
{
    public static UnityEvent<Collider2D> playerHitboxHitEvent = new();
    public static UnityEvent playerHitEvent = new();
    public static UnityEvent playerDeathEvent = new();
}
