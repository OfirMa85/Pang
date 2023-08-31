using UnityEngine;

public class CountdownView : PangElement
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameController gameController;

    public void StartCountdown()
    {
        GameModel.pauseStack++;
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
