using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageAmount = 10;

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("lo");
            other.GetComponent<MonsterStats>().TakeDamage(damageAmount);
        }
    }
   
}