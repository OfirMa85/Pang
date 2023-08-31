using UnityEngine;

public class PauseView : PangElement
{
    private const string pauseString = "pause";
    private const string unpauseString = "unpause";

    [SerializeField] private Animator animator;

    private void Start()
    {
        PauseScreenEvent.pauseScreenEvent.AddListener(PauseUnpause);
    }

    private void PauseUnpause(bool pause)
    {
        string clip = pause ? pauseString : unpauseString;
        animator.Play(clip);
    }
}
