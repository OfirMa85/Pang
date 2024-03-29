using UnityEngine;

public class PlayerModel : PangElement
{
    public PlayerBaseState currentState;

    public GameObject fireballPrefab;
    public Transform attacksParent;

    public Rigidbody2D rb;

    public bool drawBounds;
    public Vector2 xBounds;
    public float speed;
    public float invincibilityDuration = 2f;

    [HideInInspector] public bool invincible;

    private void OnDrawGizmos()
    {
        if (!drawBounds)
        {
            return;
        }

        Gizmos.DrawLine(Vector2.right * xBounds.x, Vector2.right * xBounds.y);
    }
}
