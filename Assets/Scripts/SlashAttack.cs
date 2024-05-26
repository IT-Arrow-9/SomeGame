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
    Animator _animator;
    public GameObject sword;
    Animator swordAnimator;
    
    private void Start()
    {
        
        _animator = GetComponent<Animator>();
        swordAnimator = sword.GetComponent<Animator>();
    }
    private void Update()
    {
        _Center.transform.rotation = _camera.rotation;
        if (Input.GetButtonDown("Fire1"))
        {
            _animator.SetBool("Attack",true);
            swordAnimator.SetBool("Attack", true);
        }
    }
    public void Attack()
    {
       GameObject newSlash = Instantiate(_slash, _SpawnPos.position-new Vector3(Random.Range(-1,1), Random.Range(-1, 1), Random.Range(-1, 1)), Quaternion.Euler(_camera.rotation.eulerAngles.x, _camera.rotation.eulerAngles.y * 180, Random.Range(-180,180)));
        //нанесение урона врагу
        StartCoroutine( DestroySlash(_timeZaderzhki,newSlash));
        _animator.SetBool("Attack", false);
        swordAnimator.SetBool("Attack", false);
    }

    IEnumerator DestroySlash(float i,GameObject g)
    {
        yield return new WaitForSeconds (i);
    
        Destroy(g);
    }
}
