using UnityEngine;

public class GameController : PangElement
{
    [SerializeField] private CountdownView countdown;

    private void Start()
    {
        countdown.StartCountdown();
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
