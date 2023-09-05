using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : PangElement
{
    private void Start()
    {
        InitializeGame();
    }

    private void InitializeGame()
    {
        // music
        app.controller.music.Play(Theme.Game);
        // reset score
        app.controller.score.UpdateScore(0);
        // initialize level 1
        int level = 1;
        app.model.game.level = level;
        InitializeLevel(level);
    }

    public void StartRound()
    {
        // unpause
        AddToPauseStack(-1);
    }

    public void AddToPauseStack(int amount)
    {
        app.model.pause.pauseStack += amount;
        UpdateTimeScale();
    }

    private void UpdateTimeScale()
    {
        Time.timeScale = app.model.pause.pauseStack > 0 ? 0 : 1;
    }

    public void LevelComplete()
    {
        app.model.game.level++;
        InitializeLevel(app.model.game.level);
    }

    private void InitializeLevel(int level)
    {
        AddToPauseStack(1);
        app.view.countdown.StartCountdown();
        app.controller.balls.SpawnBall(level, 1, Vector3.zero);
        app.model.balls.CountBalls();
    }
}
