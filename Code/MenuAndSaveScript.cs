using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAndSaveScript : MonoBehaviour
{
    [SerializeField] private GameObject miniMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (miniMenu.active)
            {
                miniMenu.gameObject.SetActive(false);
            }
            else
            {
                miniMenu.gameObject.SetActive(true);
            }
            
        }
    }
    public void SceneLoading(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Quit(){
        Application.Quit();
    }
    public void Save() 
    {
        //After level is done
    }
}
