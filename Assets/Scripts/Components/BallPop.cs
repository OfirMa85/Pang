using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPop : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Animator animator;

    [Range(0f, 2f)]
    [SerializeField] private float pitchMin;
    [Range(0f, 2f)]
    [SerializeField] private float pitchMax;

    [HideInInspector] public int size;

    private void Start()
    {
        RandomPitch();
        StartAnimation();
    }

    private void RandomPitch()
    {
        audioSource.pitch = Random.Range(pitchMin, pitchMax);
    }

    private void StartAnimation()
    {
        animator.SetInteger("size", size);
    }

    public void AnimationEndEvent()
    {
        Destroy(gameObject);
    }
}
