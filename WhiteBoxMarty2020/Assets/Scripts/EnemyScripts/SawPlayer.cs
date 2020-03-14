using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawPlayer : MonoBehaviour
{
    public EnemyMovement enemyMov;

    public float chaseTime = 2f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            enemyMov.currentState = EnemyMovement.enemyStates.FOLLOW;
            enemyMov.player = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(ChaseTimer());
        }
    }

    IEnumerator ChaseTimer()
    {
        yield return new WaitForSeconds(chaseTime);
        enemyMov.currentState = EnemyMovement.enemyStates.WANDER;
    }
}
