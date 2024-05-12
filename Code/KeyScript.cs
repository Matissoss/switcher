using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private Vector3 keyVector;
    private float floatSpeed;
    [SerializeField] private GameObject doorToOpen;
    private float time;
    private AudioSource src;
    [SerializeField] private AudioClip pickedUp;
    private void Awake()
    {
        src = GetComponent<AudioSource>();
        floatSpeed = 0.25f;
        time = 0.7f;
        StartCoroutine("Float", time);
    }
    private void Update()
    {
        transform.position += keyVector * Time.deltaTime * floatSpeed;
    }
    private IEnumerator Float(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        keyVector = Vector2.up;
        yield return new WaitForSecondsRealtime(time);
        keyVector = Vector2.down;
        StartCoroutine("Float", time);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            doorToOpen.SetActive(false);
            src.PlayOneShot(pickedUp, PlayerPrefs.GetFloat("SFXVolume"));
            Destroy(this.gameObject, 0.2f);
        }
    }
}
