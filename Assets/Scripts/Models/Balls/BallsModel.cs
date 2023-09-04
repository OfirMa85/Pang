using UnityEngine;

public class BallsModel : PangElement
{
    public Transform parent;
    public GameObject prefab;
    public BallScriptable[] scriptables;

    public int activeBalls;

    public void CountBalls()
    {
        activeBalls = GameObject.FindGameObjectsWithTag("Ball").Length;
    }
}
