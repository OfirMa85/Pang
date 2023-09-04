using UnityEngine;

public class LevelCompleteView : PangElement
{
    [SerializeField] private Animator animator;

    public void StartAnimation()
    {
        animator.enabled = true;
    }

    public void LevelCompleteEvent()
    {
        animator.enabled = false;
        app.controller.game.LevelComplete();
    }
}
