using UnityEngine;

public class WinView : PangElement
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        GameEvents.gameWonEvent.AddListener(OnGameWon);
    }

    private void OnGameWon()
    {
        animator.SetBool("active", true);
    }
}
