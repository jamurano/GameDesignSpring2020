using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public enum enemyStates{WANDER, FOLLOW, ATTACK};
    public enemyStates currentState;
    public List<GameObject> wanderPoint;

    public GameObject currentWanderPoint;

    public NavMeshAgent navMeshAgent;
    public GameObject player;
    public float enemyChargeSpeed = 15f;
    public float enemyWanderSpeed = 10f;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    
    void Update()
    {
        if (currentState == enemyStates.WANDER)
        {
            navMeshAgent.isStopped = false;
            if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance || navMeshAgent.destination == null)
            {
                //Wander
                // enemy pick a point to walk to
                int randomIndex = 0;
                randomIndex = UnityEngine.Random.Range(0, wanderPoint.Count);
                currentWanderPoint = wanderPoint[randomIndex];
                // then enemy walk to that point
                navMeshAgent.destination = currentWanderPoint.transform.position;
                navMeshAgent.speed = enemyWanderSpeed;
                // when it gets to that point, it chooses new point 
            }

        }
        
        else if (currentState == enemyStates.FOLLOW)
        {
            // Follow
            // if enemy sees player in SawPlayer script
            // follow player
            navMeshAgent.destination = player.transform.position;
            navMeshAgent.speed = enemyChargeSpeed;
        }

        else
        {
            //Attack
            // if enemy attack script is running dont move
            navMeshAgent.isStopped = true;
            // else wander 
        }
    }
}
