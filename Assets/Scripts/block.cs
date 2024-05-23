using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public GameObject Shild;

    float damage = 0;
    
    private void Start()
    {
        Shild.SetActive(false);
    }

    private void Update()
    {
      

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Active();
        }
        
    }
    void Active()
    {
        Shild.SetActive(true);
        StartCoroutine(DestroySlash(Power , Shild));
    }
    IEnumerator DestroySlash(float i, GameObject g)
    {
        yield return new WaitForSeconds(i);

        g.SetActive(false);
    }
}
