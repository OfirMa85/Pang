using UnityEngine;

public class CountdownView : PangElement
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameController gameController;

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
        app.model.pause.pauseStack++;
        animator.enabled = true;
    }

    public void CountdownGO()
    {
        gameController.StartRound();
    }

    public void AnimationEnd()
    {
        animator.enabled = false;
    }
}
