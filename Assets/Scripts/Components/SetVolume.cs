using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;

    [SerializeField] private float multiplier;

    public void SetLevel(float sliderValue)
    {
        float musicVol = CalculateVolume(sliderValue);
        mixer.SetFloat("MusicVol", musicVol);
    }

    private float CalculateVolume(float sliderValue)
    {
        return Mathf.Log10(sliderValue) * multiplier;
    }
}
