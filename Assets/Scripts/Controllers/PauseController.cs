using UnityEngine;

public class PauseController : PangElement
{
    [SerializeField] private PauseModel model;

    private void Start()
    {
        InputEvents.inputDownEvent.AddListener(PauseUnpauseListener);
    }

    private void PauseUnpauseListener(InputAction action)
    {
        if (action != InputAction.Pause)
        {
            return;
        }

        PauseUnpause();
    }

    private void PauseUnpause()
    {
        // swap pause state
        model.isPauseScreenOn = !model.isPauseScreenOn;
        if (model.isPauseScreenOn)
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
}
