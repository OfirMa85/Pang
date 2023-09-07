using UnityEngine;

public class BallModel: PangElement
{
    [HideInInspector] public float directionSign;
    public BallScriptable scriptable;
    public GameObject popPrefab;

    private void Awake()
    {
        directionSign = RandomDirection();
    }

    private static int RandomDirection()
    {
        return (Random.Range(0, 2) * 2) - 1;
    }
}
