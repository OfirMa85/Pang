using System;
using UnityEngine;

public class AudioController : PangElement
{
    [SerializeField]
    private Sound[] sounds;

    private void Awake()
    {
        InitializeSounds();
    }

    private void InitializeSounds()
    {
        foreach (Sound sound in this.sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();

            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.loop;
        }
    }

    public void Play(string name)
    {
        Sound sound = Array.Find(sounds, s => s.name == name);
        if (sound == null)
        {
            string error = "Sound \"" + sound.name + "\" not found";
            Debug.LogError(error);
            return;
        }

        sound.source.Play();
    }
}
