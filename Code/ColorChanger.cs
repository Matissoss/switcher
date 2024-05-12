using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private GameObject whiteColorButton;
    [SerializeField] private GameObject redColorButton;
    [SerializeField] private GameObject greenColorButton;
    [SerializeField] private GameObject blueColorButton;
    [SerializeField] private GameObject orangeColorButton;
    private void Awake()
    {
        PlayerPrefs.SetInt("Color", 1);
        PlayerPrefs.SetInt("WhiteUnlocked", 1);
        PlayerPrefs.SetInt("RedUnlocked", 0);
        PlayerPrefs.SetInt("GreenUnlocked", 0);
        PlayerPrefs.SetInt("BlueUnlocked", 0);
        PlayerPrefs.SetInt("OrangeUnlocked", 0);
    }
    private void Update()
    {
        if(PlayerPrefs.GetInt("WhiteUnlocked") == 1)
        {
            whiteColorButton.gameObject.SetActive(true);
        }
        else
        {
            whiteColorButton.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("RedUnlocked") == 1)
        {
            redColorButton.gameObject.SetActive(true);
        }
        else
        {
            redColorButton.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GreenUnlocked") == 1)
        {
            greenColorButton.gameObject.SetActive(true);
        }
        else
        {
            greenColorButton.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BlueUnlocked") == 1)
        {
            blueColorButton.gameObject.SetActive(true);
        }
        else
        {
            blueColorButton.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("OrangeUnlocked") == 1)
        {
            orangeColorButton.gameObject.SetActive(true);
        }
        else
        {
            orangeColorButton.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && PlayerPrefs.GetInt("WhiteUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && PlayerPrefs.GetInt("RedUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && PlayerPrefs.GetInt("GreenUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && PlayerPrefs.GetInt("BlueUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && PlayerPrefs.GetInt("OrangeUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 5);
        }
    }
    public void ColorChange(int color)
    {
        if(color == 1 && PlayerPrefs.GetInt("WhiteUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 1);
        }
        else if(color == 2 && PlayerPrefs.GetInt("RedUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 2);
        }
        else if(color == 3 && PlayerPrefs.GetInt("GreenUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 3);
        }
        else if(color == 4 && PlayerPrefs.GetInt("BlueUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 4);
        }
        else if(color == 5 && PlayerPrefs.GetInt("OrangeUnlocked") == 1)
        {
            PlayerPrefs.SetInt("Color", 5);
        }
    }
}
