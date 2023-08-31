using UnityEngine;

public class LetterBoxerView : PangElement
{
    public float xRatio = 16f;
    public float yRatio = 9f;

    public bool onAwake;
    public bool onUpdate;

    private Camera cam;

    // used for point rounding errors
    private static readonly float epsilon = 0.001f;

    private void Awake()
    {
        cam = Camera.main;

        if (onAwake)
        {
            UpdateLetterboxing();
        }
    }

    private void Update()
    {
        if (onUpdate)
        {
            UpdateLetterboxing();
        }
    }

    private void UpdateLetterboxing()
    {
        if (yRatio == 0)
        {
            return;
        }

        // get height scale difference
        float targetRatio = xRatio / yRatio;
        float currentRatio = (float)Screen.width / (float)Screen.height;
        float heightScale = currentRatio / targetRatio;

        // letterbox
        if (heightScale > 1f + epsilon)
        {
            float letterboxWidth = 1f - targetRatio / heightScale;
            cam.rect = new Rect(letterboxWidth * 0.5f, 0f, 1f - letterboxWidth, 1f);
        }
        // pillarbox
        else if (heightScale < 1f - epsilon)
        {
            float pillarboxHeight = 1f - currentRatio / targetRatio;
            cam.rect = new Rect(0f, pillarboxHeight * 0.5f, 1f, 1f - pillarboxHeight);
        }
        // ratio is at target
        else
        {
            cam.rect = new Rect(0f, 0f, 1f, 1f);
        }
    }
}
