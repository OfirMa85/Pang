using UnityEngine;

public class GameController : PangElement
{
    private void Start()
    {
        app.model.pause.pauseStack++;
        GameStartEvent.gameStartEvent?.AddListener(GameStartListener);
    }

    private void GameStartListener()
    {
        app.view.countdown.StartCountdown();
        app.controller.balls.SpawnBall(3, 1, Vector3.zero);
    }

    private void Update()
    {
        HandlePauseStack();
    }

    public void StartRound()
    {
        app.model.pause.pauseStack--;
    }

    private void HandlePauseStack()
    {
        Time.timeScale = app.model.pause.pauseStack > 0 ? 0 : 1;
    }
}
