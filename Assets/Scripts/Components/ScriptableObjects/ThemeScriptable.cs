using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class ThemeScriptable : ScriptableObject
{
    public Theme theme;
    public AudioClip clip;

    [Range(0f, 2f)]
    public float volume = 1;
}
