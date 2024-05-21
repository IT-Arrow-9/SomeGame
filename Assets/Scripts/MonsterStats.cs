using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class MonsterStats : MonoBehaviour
{
  // [SerializeField]
     public int HP = 100;
    VisualEffect vfx;
    
    private void Start()
    {
        vfx = gameObject.GetComponentInChildren<VisualEffect>();
    }
    

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount; // Снятие урона от здоровья
        Debug.Log("hui");
        if (HP <= 0) // Если здоровье врага стало меньше или равно нулю
        {
            Death();
        }
    }
    private void Death()
    {

    }
    
    
}
