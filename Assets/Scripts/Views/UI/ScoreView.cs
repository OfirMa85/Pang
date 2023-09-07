using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreView : PangElement
{
    [SerializeField] TextMeshProUGUI tmp;

    public void UpdateScore(int score, int highscore)
    {
        string finalText = app.model.score.highscoreText;
        finalText += highscore;
        finalText += "\n";
        finalText += app.model.score.scoreText;
        finalText += score;

        tmp.text = finalText;
    }

    public void DisplayHighscore(int highscore)
    {
        string finalText = app.model.score.highscoreText;
        finalText += highscore;

        tmp.text = finalText;
    }
}
