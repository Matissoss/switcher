using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Vector3 playerVector;
    private Rigidbody2D playerRb;
    [SerializeField] private float speed;
    [SerializeField] private int jumpForce;
    [SerializeField] private Camera mainCam;
    [SerializeField] private AudioClip jump;
    private AudioSource src;
    private Animator playerAnimator;
    private bool canJump;
    private Colors color;
    private enum Colors
    {
        red,
        blue,
        green,
        white,
        orange
    }
    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        src = GetComponent<AudioSource>();
        playerRb = GetComponent <Rigidbody2D>();
        this.gameObject.layer = 7;
        mainCam.backgroundColor = Color.red;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        canJump = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerVector.x = -1;
            playerAnimator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerVector.x = 1;
            playerAnimator.SetBool("isWalking", true);
        }
        else
        {
            playerVector.x = 0;
            playerAnimator.SetBool("isWalking", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            playerRb.AddForce(Vector2.up * jumpForce);
            src.PlayOneShot(jump, PlayerPrefs.GetFloat("SFXVolume"));
        }
        transform.position += playerVector * Time.deltaTime * speed;
    }
}
