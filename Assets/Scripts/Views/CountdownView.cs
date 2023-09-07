using UnityEngine;

public class CountdownView : PangElement
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        PauseScreenEvent.pauseScreenEvent.AddListener(PauseListener);
    }

    private void PauseListener(bool pause)
    {
        animator.speed = pause ? 0 : 1;
    }

    public void StartCountdown()
    {
        animator.enabled = true;
    }

    public void CountdownGO()
    {
        app.controller.game.StartRound();
    }

    public void AnimationEnd()
    {
        animator.enabled = false;
    }
}
