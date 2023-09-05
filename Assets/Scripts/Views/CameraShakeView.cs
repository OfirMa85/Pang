using UnityEngine;

public class CameraShakeView : MonoBehaviour
{
    private Camera cam;
    private Vector3 originPos;

    private float duration;
    private float intensity;

    private void Awake()
    {
        cam = Camera.main;
        originPos = cam.transform.position;
    }

    private void Update()
    {
        if (duration > 0)
        {
            ShakeUpdate();
        }
    }

    private void ShakeUpdate()
    {
        Vector3 movement = Random.insideUnitSphere * intensity;
        cam.transform.localPosition =  originPos + movement;
        duration = Mathf.Max(0, duration - Time.unscaledDeltaTime);
    }

    public void Shake(float duration, float intensity)
    {
        // ignore a weaker shake
        if (intensity < this.intensity && this.duration > 0)
        {
            return;
        }

        this.duration = duration;
        this.intensity = intensity;
    }
}
