using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    NavMeshAgent agent;
    Animator animator;
    void Start()
    {
       agent= GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, playerPosition.position)<=1.75) 
        {
            animator.SetBool("Attack",true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
        agent.SetDestination(playerPosition.position);
    }
}
