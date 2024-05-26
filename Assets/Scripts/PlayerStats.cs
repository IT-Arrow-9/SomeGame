using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    float MaxHP,HP,Intencity,MinIntecity,MaxIntecity;
    [SerializeField]
    Material Polosi;
    [SerializeField] 
    private Color _emissionColorValue;
    public GameObject UI_WIN;
    public GameObject UI_LOSE;
    public bool isUIActive;
    void Start()
    {
        isUIActive = false;
    }
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
    }
    // Update is called once per frame
    void Update()
    {
        float Minus_Intencity = ((MaxHP - HP) * (MaxIntecity - MinIntecity))/MaxHP;
        Intencity = MaxIntecity - Minus_Intencity;
        Polosi.SetColor("_EmissionColor", _emissionColorValue*Intencity);
        var Enemies = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log(Enemies.Length);
        if(Enemies.Length == 0)
        {
            UI_WIN .SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        if (HP<= 0 )
        {
            UI_LOSE.SetActive(true);
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

    }
    public void Zanovo()
    {
        SceneManager.LoadScene(3);
    }
}
