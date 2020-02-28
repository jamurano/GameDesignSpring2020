using UnityEngine;

public class SawPlayer : MonoBehaviour
{
    public EnemyMovement enemyMov;
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
            enemyMov.currentState = EnemyMovement.enemyStates.WANDER;
        }
    }
}
