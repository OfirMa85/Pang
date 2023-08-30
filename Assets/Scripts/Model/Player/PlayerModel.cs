using UnityEditor;
using UnityEngine;

public class PlayerModel : PangElement
{
    public PlayerInputModel input;
    public PlayerBaseState currentState;

    public GameObject fireballPrefab;
    public Transform attacksParent;

    public bool drawBounds;
    public Vector2 xBounds;
    public float speed;

    private void OnDrawGizmos()
    {
        if (!drawBounds)
        {
            return;
        }

        Gizmos.DrawLine(Vector2.right * xBounds.x, Vector2.right * xBounds.y);
    }
}
