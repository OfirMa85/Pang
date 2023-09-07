using UnityEngine;

public class ScoreModel : PangElement
{
    [HideInInspector] public readonly string scoreText = "score: ";
    [HideInInspector] public int score;
}
