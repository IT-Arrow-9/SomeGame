using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageAmount = 10;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("l");
        if ((other.tag == "Enemy"))
        {
            Debug.Log("lo");
            other.GetComponent<statsmonster>().TakeDamage(damageAmount);
        }
    }
}