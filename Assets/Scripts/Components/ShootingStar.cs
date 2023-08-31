using System.Collections;
using System.Collections.Generic;
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
        transform.position += speed * Time.deltaTime * direction.normalized;
    }

    private void HandleLifetime()
    {
        timer += Time.deltaTime;
        if (timer > lifetime)
        {
            Destroy(gameObject);
        }
    }
}
