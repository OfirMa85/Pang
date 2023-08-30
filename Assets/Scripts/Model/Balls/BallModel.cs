using UnityEngine;

public class BallModel: PangElement
{
    [HideInInspector] public float directionSign;
    [HideInInspector] public BallScriptable scriptable;

    public void Initialize(BallScriptable scriptable, int directionSign)
    {
        this.scriptable = scriptable;
        this.directionSign = directionSign;
    }
}
