using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 5;
    public LayerMask enemyLayer;
    public MonsterStats otherscritpt;

    public void OnTriggerEnter(Collider other)
    {
        if (enemyLayer == (enemyLayer | (1 << other.gameObject.layer)))
        {
            Debug.Log("мать ебал");
            MonsterStats enemyHealth = other.GetComponent<MonsterStats>();
            if (enemyHealth == null)
            {
                enemyHealth.TakeDamage(damage);
                Debug.Log("сын шалавы");
            }

        }
    }
}