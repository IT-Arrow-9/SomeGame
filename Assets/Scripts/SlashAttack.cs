using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashAttack : MonoBehaviour
{
    
    [SerializeField]
   private GameObject _slash;
    [SerializeField]
    private float _timeZaderzhki;
    [SerializeField]
    private Transform _SpawnPos;
    [SerializeField]
    private Transform _camera;
    [SerializeField]
    private GameObject _Center;
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        _Center.transform.rotation = _camera.rotation;
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
           // Debug.Log(_camera.rotation.eulerAngles.x);
        }
    }
    void Attack()
    {
       GameObject newSlash = Instantiate(_slash, _SpawnPos.position-new Vector3(Random.Range(-1,1), Random.Range(-1, 1), Random.Range(-1, 1)), Quaternion.Euler(_camera.rotation.eulerAngles.x, _camera.rotation.eulerAngles.y * 180, Random.Range(-180,180)));
        //нанесение урона врагу
        StartCoroutine( DestroySlash(_timeZaderzhki,newSlash));
    }

    IEnumerator DestroySlash(float i,GameObject g)
    {
        yield return new WaitForSeconds (i);
    
        Destroy(g);
    }
}
