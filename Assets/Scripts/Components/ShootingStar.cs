using UnityEngine;

public class ShootingStar : PangElement
{
    public Vector3 direction;
    public float speed;
    public float lifetime;

    private float timer = 0;

    [SerializeField] private ParticleSystem particle;

    private void Update()
    {
        HandleMovement();
        HandleLifetime();
        ManualSimulation();
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

    private void ManualSimulation()
    {
        if (!app.model.pause.IsPaused())
        {
            return;
        }

        particle.Simulate(Time.unscaledDeltaTime, true, false);
    }
}
