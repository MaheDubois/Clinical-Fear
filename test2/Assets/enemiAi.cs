using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemiAi : MonoBehaviour
{
    public Transform player; // Assign the player GameObject here in the Inspector
    private NavMeshAgent navMeshAgent; // Corrected the variable name to be consistent
    private Animator animator; // Reference to the Animator component

    void Start()
    {
        animator = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();

        NavMeshHit hit; // Corrected the variable declaration

        if (NavMesh.SamplePosition(transform.position, out hit, 1.0f, NavMesh.AllAreas))
        {
            navMeshAgent.Warp(hit.position); // Corrected the variable name to be consistent
        }
        else
        {
            Debug.LogWarning("L'ennemi n'est pas placé correctement sur le NavMesh.");
        }
    }

    void Update()
    {
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);

            // Play the walk animation
            if (navMeshAgent.velocity.magnitude > 0.1f)
            {
                animator.SetBool("isWalking", true);
            }
            else
            {
                animator.SetBool("isWalking", false);
            }
        }
    }
}
