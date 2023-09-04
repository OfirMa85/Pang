using System.Drawing;
using UnityEngine;
using UnityEngine.Events;

public class BallController: PangElement
{
    [SerializeField] private BallModel model;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private new CircleCollider2D collider;

    public void Initialize()
    {
        InitializeHitbox();
        Boost();
    }

    private void InitializeHitbox()
    {
        collider.radius = model.scriptable.hitboxRadius;
    }

    private void Update()
    {
        MoveHorizontally();
    }
    private void MoveHorizontally()
    {
        float movement = model.directionSign * model.scriptable.horizontalSpeed * Time.deltaTime;
        transform.position += movement * Vector3.right;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Lower Bound":
                LowerBound();
                break;
            case "Right Bound":
                SideBound(-1);
                break;
            case "Left Bound":
                SideBound(1);
                break;
            case "Attack":
                OnHit();
                break;
            default:
                break;
        }
    }
    private void LowerBound()
    {
        // bounce up
        rb.velocity = Vector2.up * model.scriptable.verticalSpeed;
    }

    private void SideBound(int newSign)
    {
        model.directionSign = newSign;
    }

    public void OnHit()
    {
        BallDestroyEvent.ballDestroyEvent?.Invoke(transform.position, model.scriptable);
        Destroy(gameObject);
    }

    public void Boost()
    {
        rb.velocity = Vector2.up * model.scriptable.boostSpeed;
    }
}
