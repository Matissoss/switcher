using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickup : MonoBehaviour
{
    [SerializeField] private int color;
    private AudioSource src;
    [SerializeField] private AudioClip pickedUp;

    private void Awake()
    {
        src = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            ColorUnlocker();
            src.PlayOneShot(pickedUp, PlayerPrefs.GetFloat("SFXVolume"));
            Destroy(this.gameObject, 0.2f);
        }
    }
    private void ColorUnlocker()
    {
        switch (color)
        {
            case 1:
                PlayerPrefs.SetInt("WhiteUnlocked", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("RedUnlocked", 1);
                break;
            case 3:
                PlayerPrefs.SetInt("GreenUnlocked", 1);
                break;
            case 4:
                PlayerPrefs.SetInt("BlueUnlocked", 1);
                break;
            case 5:
                PlayerPrefs.SetInt("OrangeUnlocked", 1);
                break;
        }
    }
}
