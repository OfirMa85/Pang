using UnityEngine;

public class PauseView : PangElement
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        GameEvents.gameLostEvent.AddListener(OnGameEnded);
        GameEvents.gameWonEvent.AddListener(OnGameEnded);
        PauseScreenEvent.pauseScreenEvent.AddListener(PauseUnpause);
    }

    private void PauseUnpause(bool pause)
    {
        animator.SetBool("active", pause);
    }

    private void OnGameEnded()
    {
        animator.SetBool("active", false);
    }
}
