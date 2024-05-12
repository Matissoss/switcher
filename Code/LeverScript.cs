using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    private bool canSwitch;
    private bool wasSwitched;
    private int leverStatus;
    private SpriteRenderer leverRenderer;
    [SerializeField] private Sprite leverOff;
    [SerializeField] private Sprite leverOffOn;
    [SerializeField] private Sprite leverOn;
    [SerializeField] private GameObject doorToOpen;
    private AudioSource src;
    [SerializeField] private AudioClip switched;
    private void Awake()
    {
        src = GetComponent<AudioSource>();
        wasSwitched = false;
        leverRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.name == "Player")
        {
            canSwitch = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canSwitch = false;
    }
    private void Update()
    {
        switch (leverStatus)
        {
            case 1:
                leverRenderer.sprite = leverOff;
                doorToOpen.SetActive(true);
                break;
            case 2:
                leverRenderer.sprite = leverOffOn;
                break;
            case 3:
                leverRenderer.sprite = leverOn;
                wasSwitched = true;
                doorToOpen.SetActive(false);
                break;
        }
        if (Input.GetKeyDown(KeyCode.E) && !wasSwitched)
        {
            StartCoroutine("animation");
        }
    }
    private IEnumerator animation()
    {
        leverStatus = 1;
        src.PlayOneShot(switched, PlayerPrefs.GetFloat("SFXVolume"));
        yield return new WaitForEndOfFrame();
        leverStatus = 2;
        yield return new WaitForEndOfFrame();
        leverStatus = 3;
    }
}
