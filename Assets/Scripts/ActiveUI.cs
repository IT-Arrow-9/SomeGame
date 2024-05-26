using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ActiveUI : MonoBehaviour
{
    public GameObject UI;
    public GameObject vfx;
    bool a = false;
    private void Start()
    {
        UI.SetActive(false);
        vfx.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&a)
        {
            SceneManager.LoadScene(3);
        }
        Debug.Log(a);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(true);
            vfx.SetActive(false);
            a = true;
        }
        


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(false);
            vfx.SetActive(true);
            a = false;
        }
    }
}
