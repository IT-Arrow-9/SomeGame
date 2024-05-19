using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mutant_Chase : StateMachineBehaviour
{
    NavMeshAgent agent;
    Transform player;
    [SerializeField]
    float attackRange = 4;
    [SerializeField]
    float chaseRange = 10;

    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent = animator.GetComponent<NavMeshAgent>();
        agent.speed = 4;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(player.position);
        float distance = Vector3.Distance(animator.transform.position, player.position);

        if(distance < attackRange)
        {
            animator.SetBool("IsAttack", true);
        }
       
        if(distance > chaseRange)
        {
            animator.SetBool("IsChase", false);
        }
       
        
        Debug.Log(distance);
    }

  
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
        agent.speed = 2;
    }

   
}
