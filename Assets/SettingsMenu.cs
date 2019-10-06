using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public Slider soundSlider;
    public Slider musicSlider;
    private void Awake()
    {

    }

    void Start()
    {
        if (!PlayerPrefs.HasKey("SoundSliderValue"))
        {
            PlayerPrefs.SetInt("SoundSliderValue", 1);
        }
        if (!PlayerPrefs.HasKey("MusicSliderValue"))
        {
            PlayerPrefs.SetInt("MusicSliderValue", 1);
        }


        soundSlider.value = PlayerPrefs.GetFloat("SoundSliderValue");
        musicSlider.value = PlayerPrefs.GetFloat("MusicSliderValue");

    }

    void Update()
    {
        PlayerPrefs.SetFloat("SoundSliderValue", soundSlider.value);
        PlayerPrefs.SetFloat("MusicSliderValue", musicSlider.value);
    }

    public void SetSoundVolume(float volume)
    {
        AudioManager.GetInstance().SetSoundVolume(volume);
    }

    public void SetMusicVolume(float volume)
    {
        AudioManager.GetInstance().SetMusicVolume(volume);
    }
    
}
