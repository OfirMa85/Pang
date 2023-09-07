using UnityEngine;

public class ScoreModel : PangElement
{
    [HideInInspector] public readonly string highscoreText = "Highscore: ";
    [HideInInspector] public readonly string scoreText = "Score: ";
    [HideInInspector] public static int highscore;
    [HideInInspector] public int score;
}
