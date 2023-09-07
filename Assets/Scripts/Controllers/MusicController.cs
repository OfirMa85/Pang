using System.Collections.Generic;
using UnityEngine;

public class MusicController : PangElement
{
    [SerializeField]
    private ThemeScriptable[] themes;

    private readonly Dictionary<ThemeScriptable, AudioSource> sources = new();

    private void Awake()
    {
        InitializeSources();
    }

    private void InitializeSources()
    {
        foreach (ThemeScriptable theme in themes)
        {
            // add audio source
            AudioSource source = gameObject.AddComponent<AudioSource>();
            source.clip = theme.clip;
            source.volume = theme.volume;
            source.loop = true;
            source.outputAudioMixerGroup = app.model.music.mixer;
            sources.Add(theme, source);
        }
    }

    public void Play(Theme theme)
    {
        bool success = false;

        foreach (KeyValuePair<ThemeScriptable, AudioSource> pair in sources)
        {
            if (pair.Key.theme == theme)
            {
                pair.Value.Play();
                success = true;
            }
            else
            {
                pair.Value.Pause();
            }
        }

        // theme not found
        if (!success)
        {
            Debug.LogError("Theme not setup correctly");
            return;
        }
    }
}
