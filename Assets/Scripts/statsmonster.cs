using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsmonster : MonoBehaviour
{
    [SerializeField]
    float HP;
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
    }

}
