using UnityEngine;

public class BallModel: PangElement
{
    [HideInInspector] public float directionSign;
    public GameObject popPrefab;
    public BallScriptable scriptable;

    public void Initialize(BallScriptable scriptable, int directionSign)
    {
        this.scriptable = scriptable;
        this.directionSign = directionSign;
    }
}
