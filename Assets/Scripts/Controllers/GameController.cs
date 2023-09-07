using UnityEngine;

public class GameController : PangElement
{
    private void Start()
    {
        InitializeGame();

        GameEvents.gameLostEvent.AddListener(OnGameEnded);
        GameEvents.gameWonEvent.AddListener(OnGameEnded);
    }

    private void InitializeGame()
    {
        // music
        app.controller.music.Play(Theme.Game);
        // reset score
        app.controller.score.UpdateScore(0);

        app.controller.level.LoadLevel(1);
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
        app.controller.level.NextLevel();
    }

    private void OnGameEnded()
    {
        AddToPauseStack(1);
    }
}
