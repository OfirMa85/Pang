using UnityEngine;

public class LoseView : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        PlayerHitEvents.playerDeathEvent.AddListener(OnPlayerDeath);
    }

    private void OnPlayerDeath()
    {
        animator.SetBool("active", true);
    }
}
