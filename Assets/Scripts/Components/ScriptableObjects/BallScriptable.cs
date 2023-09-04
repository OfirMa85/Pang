using UnityEngine;

[CreateAssetMenu]
public class BallScriptable : ScriptableObject
{
    [Header("Tier")]
    public int size;
    public int score;
    public BallScriptable next;

    [Header("Speeds")]
    public float verticalSpeed;
    public float horizontalSpeed;
    public float boostSpeed;

    [Header("Sprite")]
    public Sprite sprite;
    public float hitboxRadius;
}
