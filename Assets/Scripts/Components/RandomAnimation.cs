using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation : MonoBehaviour
{
    [Range(0, 10)]
    [SerializeField]
    private int animations;

    private Animator animator;

    private void Start()
    {
        RandomizeClip();
        RandomizeTime();
    }

    private void RandomizeClip()
    {
        animator = GetComponent<Animator>();
        animator.SetInteger("random", Random.Range(0, animations));
    }

    private void RandomizeTime()
    {
        AnimatorStateInfo state = animator.GetCurrentAnimatorStateInfo(0);
        animator.Play(state.fullPathHash, 0, Random.Range(0f, 1f));
    }
}
