using UnityEngine;

public class PlayerAnimationView : PangElement
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayAnimation(string state)
    {
        animator.Play(state);
    }

    public void AnimationEnd()
    {
        app.model.player.currentState.OnAnimationEnd(app.controller.player.state);
    }

    public void ToggleInvincibility(bool invincible)
    {
        animator.SetBool("invincible", invincible);
    }
}
