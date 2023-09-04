using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class Sound : ScriptableObject
{
    public new string name;

    public AudioClip clip;

    [Range(0f, 2f)]
    public float volume = 1;
    [Range(0f, 2f)]
    public float pitch = 1;
    [Range(0f, 1f)]
    public float pitchRandomness;
    public bool loop;

    [HideInInspector] public AudioSource source;
}
