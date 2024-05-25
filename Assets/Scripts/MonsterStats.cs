using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class MonsterStats : MonoBehaviour
{
   [SerializeField]
     public float HP = 100;
    VisualEffect vfx;
    public float n;
    
    private void Start()
    {
        vfx = gameObject.GetComponentInChildren<VisualEffect>();
    }

    private void Update()
    {
        n = HP / 100;
        Debug.Log(n);
        if (HP<=0)
        {
            Death();
        }
        vfx.SetFloat("HP",HP);
        vfx.SetFloat("HP_Color", (n));

    }
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
    }
    private void Death()
    {
        Destroy(gameObject);
    }
   


}
