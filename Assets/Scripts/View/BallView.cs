using UnityEngine;

public class BallView : PangElement
{
    private BallController ball;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private new CircleCollider2D collider;

    public void OnSpawn(BallController ball)
    {
        this.ball = ball;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<CircleCollider2D>();

        InitializeObject();
    }
    private void InitializeObject()
    {
        // set radius
        collider.radius = ball.scriptable.hitboxRadius;

        // set sprite
        if (ball.scriptable.sprite == null)
        {
            Debug.LogError("Ball Sprite is not defined");
            return;
        }
        sprite.sprite = ball.scriptable.sprite;
    }

    public void Move()
    {
        // move left and right
        float movement = ball.model.directionSign * ball.scriptable.horizontalSpeed * Time.deltaTime;
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
        rb.velocity = Vector2.up * ball.scriptable.verticalSpeed;
    }

    private void SideBound(int newSign)
    {
        ball.model.directionSign = newSign;
    }

    public void OnHit()
    {
        ball.model.controller.DestroyBall(ball);
        Destroy(gameObject);
    }

    public void Boost()
    {
        rb.velocity = Vector2.up * ball.scriptable.boostSpeed;
    }
}
