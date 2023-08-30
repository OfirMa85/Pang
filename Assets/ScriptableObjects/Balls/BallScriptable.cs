using UnityEngine;

[CreateAssetMenu]
public class BallScriptable : ScriptableObject
{
    [Header("Size")]
    public int size;

    [Header("Speeds")]
    public float verticalSpeed;
    public float horizontalSpeed;
    public float boostSpeed;

    [Header("Sprite")]
    public Sprite sprite;
    public float hitboxRadius;
}
