using UnityEngine;

public class ShootingStar : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public float lifetime;

    private float timer = 0;

    private void Update()
    {
        HandleMovement();
        HandleLifetime();
    }

    private void HandleMovement()
    {
        transform.position += speed * Time.unscaledDeltaTime * direction.normalized;
    }

    private void HandleLifetime()
    {
        timer += Time.unscaledDeltaTime;
        if (timer > lifetime)
        {
            Destroy(gameObject);
        }
    }
}
