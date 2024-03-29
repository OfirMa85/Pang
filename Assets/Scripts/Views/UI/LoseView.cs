using UnityEngine;

public class LoseView : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        GameEvents.gameLostEvent.AddListener(OnPlayerDeath);
    }

    private void OnPlayerDeath()
    {
        animator.SetBool("active", true);
    }
}
