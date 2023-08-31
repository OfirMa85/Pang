using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.unscaledDeltaTime);
    }
}
