using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayarDamage : MonoBehaviour
{
    public int damageAmount = 10;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("l");
        if ((other.tag == "Player"))
        {
            Debug.Log("reg");
            other.GetComponent<PlayerStats>().TakeDamage(damageAmount);
        }
    }
}
