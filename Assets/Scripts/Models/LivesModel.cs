using UnityEngine;

public class LivesModel : PangElement
{
    public int lives = 3;

    public GameObject heartPrefab;
    public Vector3 heartsPos;
    public float heartsDistance;

    public GameObject[] hearts;

    public Sprite emptyHeartSprite;
}
