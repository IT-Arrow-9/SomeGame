using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutant_Attack : StateMachineBehaviour
{
    Transform player;
    
    bool activated;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        activated = true;

    }

   
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
      
        animator.transform.LookAt(player);
        float distance = Vector3.Distance(animator.transform.position, player.transform.position);
        if (distance > 15)
            animator.SetBool("IsAttack", false);
        
    }

    
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        activated = false;
    }

   
}
