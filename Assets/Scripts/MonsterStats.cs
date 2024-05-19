using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class MonsterStats : MonoBehaviour
{
    [SerializeField]
    private float HP = 100;
    VisualEffect vfx;
    private void Start()
    {
        vfx = gameObject.GetComponentInChildren<VisualEffect>();
    }
    private void Update()
    {
        vfx.SetFloat("HP", HP);
        if(HP<= 0)
        {
            
        }
    }
    private void Death()
    {

    }
    
}
