using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : PangElement
{
    private void Start()
    {
        BallDestroyEvent.ballDestroyEvent.AddListener(OnBallDestroy);
    }

    private void OnBallDestroy(Vector3 pos, BallScriptable scriptable)
    {
        app.view.cameraShake.Shake(0.3f, scriptable.shakeIntensity);
    }
}
