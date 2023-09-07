using UnityEngine;

public class PauseController : PangElement
{
    private void Start()
    {
        InputEvents.inputDownEvent.AddListener(PauseUnpauseListener);

        GameEvents.gameLostEvent.AddListener(OnGameEnded);
        GameEvents.gameWonEvent.AddListener(OnGameEnded);
    }

    private void PauseUnpauseListener(InputAction action)
    {
        if (action != InputAction.Pause)
        {
            return;
        }

        PauseUnpause();
    }

    public void PauseUnpause()
    {
        // swap pause state
        app.model.pause.isPauseScreenOn = !app.model.pause.isPauseScreenOn;
        if (app.model.pause.isPauseScreenOn)
        {
            Pause();
        }
        else
        {
            Unpause();
        }
    }

    private void Pause()
    {
        app.controller.game.AddToPauseStack(1);
        app.controller.music.Play(Theme.Pause);
        PauseScreenEvent.pauseScreenEvent.Invoke(true);
    }

    private void Unpause()
    {
        app.controller.game.AddToPauseStack(-1);
        app.controller.music.Play(Theme.Game);
        PauseScreenEvent.pauseScreenEvent.Invoke(false);
    }

    private void OnGameEnded()
    {
        if (app.model.pause.isPauseScreenOn)
        {
            Unpause();
        }

        InputEvents.inputDownEvent.RemoveListener(PauseUnpauseListener);
    }
}
