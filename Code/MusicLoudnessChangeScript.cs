using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicLoudnessChangeScript : MonoBehaviour
{
    [SerializeField] private Slider musicVolume;
    [SerializeField] private Slider sfxVolume;
    private void Update()
    {
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume.value);
        PlayerPrefs.SetFloat("MusicVolume", musicVolume.value);
    }
}
