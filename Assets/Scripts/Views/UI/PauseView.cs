using UnityEngine;

public class PauseView : PangElement
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        PlayerHitEvents.playerDeathEvent.AddListener(OnPlayerDeath);
        PauseScreenEvent.pauseScreenEvent.AddListener(PauseUnpause);
    }

    private void PauseUnpause(bool pause)
    {
        animator.SetBool("active", pause);
    }

    private void OnPlayerDeath()
    {
        animator.SetBool("active", false);
    }
}
