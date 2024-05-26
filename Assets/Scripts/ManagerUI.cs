using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerUI : MonoBehaviour
{

    public GameObject UI;
    PlayerStats PS;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        UI.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            UI.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible =true;
            
        }
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void Continue()
    {
        UI.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void ReturnToBase()
    {
        SceneManager.LoadScene(1);
    }

}
