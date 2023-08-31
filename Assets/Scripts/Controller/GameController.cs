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
        GameModel.pauseStack--;
    }

    private void HandlePauseStack()
    {
        Time.timeScale = GameModel.pauseStack > 0 ? 0 : 1;
    }
}
