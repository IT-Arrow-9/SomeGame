using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class MonsterStats : MonoBehaviour
{
   // [SerializeField]
     private float HP = 100;
    VisualEffect vfx;
    
    private void Start()
    {
        vfx = gameObject.GetComponentInChildren<VisualEffect>();
    }
    public void TakeDamage(int damage)
    {
        HP -= damage;
       
    }
    private void Death()
    {

    }
    
    
}
