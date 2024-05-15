using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private float seeingFurther;
    private Camera mainCamera;

    [Header("Music")]
    [SerializeField] private AudioClip soundtrack1;
    [SerializeField] private AudioClip soundtrack2;
    [SerializeField] private AudioClip soundtrack3;
    [SerializeField] private AudioClip soundtrack4;
    [SerializeField] private AudioClip soundtrack5;
    private AudioSource audioSource;
    private void Awake()
    {
        PlayerPrefs.SetFloat("MusicVolume", 1);
        audioSource = GetComponent<AudioSource>();
        mainCamera = GetComponent<Camera>();
        MusicPlayer();
    }
    private IEnumerator waitForEndOfSoundtrack()
    {
        yield return new WaitForEndOfFrame();
        if (!audioSource.isPlaying)
        {
            MusicPlayer();
        }
        else{
            StartCoroutine("waitForEndOfSoundtrack");
        }
    }
    private void MusicPlayer()
    {
        int musicChoice = Random.Range(1, 3);
        if(musicChoice == 1)
        {
            audioSource.PlayOneShot(soundtrack1);
        }
        else if(musicChoice == 2)
        {
            audioSource.PlayOneShot(soundtrack2);
        }
        else if(musicChoice == 3)
        {
            audioSource.PlayOneShot(soundtrack3);
        }
        else if (musicChoice == 4)
        {
            audioSource.PlayOneShot(soundtrack4);
        }
        else if (musicChoice == 5)
        {
            audioSource.PlayOneShot(soundtrack5);
        }
        StartCoroutine("waitForEndOfSoundtrack");
    }
    private void LateUpdate()
    {
        transform.position = player.transform.position - new Vector3(0, -3, 10);
    }
    private void Update()
    {
        audioSource.volume = PlayerPrefs.GetFloat("MusicVolume");
        if (Input.GetKey(KeyCode.A))
        {
            seeingFurther = 0.5f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            seeingFurther = -0.5f;
        }
        switch (PlayerPrefs.GetInt("Color")) 
        {
            case 0:
                mainCamera.backgroundColor = Color.gray;
                break;
            case 1:
                mainCamera.backgroundColor = Color.white;
                break;
            case 2:
                mainCamera.backgroundColor = Color.red;
                break;
            case 3:
                mainCamera.backgroundColor = Color.green;
                break;
            case 4:
                mainCamera.backgroundColor = Color.blue;
                break;
            case 5:
                mainCamera.backgroundColor = new Color(1, 0.5f, 0);
                break;
        
        }

    }
}
