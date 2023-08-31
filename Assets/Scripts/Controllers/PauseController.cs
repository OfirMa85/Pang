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
        model.pauseStack += model.isPauseScreenOn ? 1 : -1;
        // invoke event
        PauseScreenEvent.pauseScreenEvent.Invoke(model.isPauseScreenOn);
    }
}
