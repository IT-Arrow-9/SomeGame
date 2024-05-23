using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    float MaxHP,HP,Intencity,MinIntecity,MaxIntecity;
    [SerializeField]
    Material Polosi;
    [SerializeField] 
    private Color _emissionColorValue;
    void Start()
    {
        
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
    }
}
