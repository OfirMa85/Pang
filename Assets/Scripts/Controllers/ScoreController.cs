using UnityEngine;

public class ScoreController : PangElement
{
    private void Start()
    {
        BallDestroyEvent.ballDestroyEvent?.AddListener(OnBallDestroy);
        app.view.score.DisplayHighscore(ScoreModel.highscore);
    }

    private void OnBallDestroy(Vector3 pos, BallScriptable scriptable)
    {
        UpdateScore(scriptable.score);
    }

    public void UpdateScore(int score)
    {
        app.model.score.score += score;
        UpdateHighscore();
        app.view.score.UpdateScore(app.model.score.score, ScoreModel.highscore);
    }

    private void UpdateHighscore()
    {
        ScoreModel.highscore = Mathf.Max(ScoreModel.highscore, app.model.score.score);
    }
}
