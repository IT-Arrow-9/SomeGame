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
        HP -= damageAmount; // ������ ����� �� ��������
        Debug.Log("hui");
        if (HP <= 0) // ���� �������� ����� ����� ������ ��� ����� ����
        {
            Death();
        }
    }
    private void Death()
    {

    }
    
    
}
