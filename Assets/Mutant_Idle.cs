using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutant_Idle : StateMachineBehaviour
{
    float timer;
    Transform player;
    [SerializeField]
    float attackRange = 2;
    [SerializeField]
    float chaseRange = 10;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       timer += Time.deltaTime;
        if(timer > 5)
        {
            animator.SetBool("IsPatrool",true);
        }
        float distance = Vector3.Distance(animator.transform.position, player.transform.position);
        if(distance<chaseRange)
        {
            animator.SetBool("IsChase", true);
        }
    }

   
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

 
    
}
