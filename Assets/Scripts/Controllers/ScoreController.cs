using UnityEngine;

public class ScoreController : PangElement
{
    private void Start()
    {
        BallDestroyEvent.ballDestroyEvent?.AddListener(OnBallDestroy);
    }

    private void OnBallDestroy(Vector3 pos, BallScriptable scriptable)
    {
        UpdateScore(scriptable.score);
    }

    public void UpdateScore(int score)
    {
        app.model.score.score += score;
        app.view.score.UpdateScore(app.model.score.scoreText, app.model.score.score);
    }
}
