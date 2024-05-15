using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManagerScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> boxesAndObstacles;
    private void Awake()
    {
        for (int i = 1; i <= transform.childCount; i++)
        {
            boxesAndObstacles.Add(transform.GetChild(i-1).gameObject);
        }
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("Color") == 0)
        {
            foreach (GameObject box in boxesAndObstacles)
            {
                box.gameObject.SetActive(true);
            }
        }
        if(PlayerPrefs.GetInt("Color") == 1)
        {
            foreach(GameObject box in boxesAndObstacles)
            {
                if(box.layer == 10)
                {
                    box.SetActive(false);
                }
                else
                {
                    box.SetActive(true);
                }
            }
        }
        if (PlayerPrefs.GetInt("Color") == 2)
        {
            foreach (GameObject box in boxesAndObstacles)
            {
                if (box.layer == 7)
                {
                    box.SetActive(false);
                }
                else
                {
                    box.SetActive(true);
                }
            }
        }
        if (PlayerPrefs.GetInt("Color") == 3)
        {
            foreach (GameObject box in boxesAndObstacles)
            {
                if (box.layer == 8)
                {
                    box.SetActive(false);
                }
                else
                {
                    box.SetActive(true);
                }
            }
        }
        if (PlayerPrefs.GetInt("Color") == 4)
        {
            foreach (GameObject box in boxesAndObstacles)
            {
                if (box.layer == 6)
                {
                    box.SetActive(false);
                }
                else
                {
                    box.SetActive(true);
                }
            }
        }
        if (PlayerPrefs.GetInt("Color") == 5)
        {
            foreach (GameObject box in boxesAndObstacles)
            {
                if (box.layer == 9)
                {
                    box.SetActive(false);
                }
                else
                {
                    box.SetActive(true);
                }
            }
        }
    }
}
