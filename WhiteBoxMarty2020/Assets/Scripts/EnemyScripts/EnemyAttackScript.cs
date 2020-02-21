using System.Collections;
using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemyHitBox;
    
    public bool isAttacking;
    public bool canAttack = false;

    public float attackWait;
    public float attackCycleWait;
    
    void OnTriggerEnter(Collider other)
    {
        print("IsWorking");
        //If (player stays in collider){
        if (other.tag == "Player")
        {
            canAttack = true;
            // Then EnemyWander stops
            enemy.GetComponent<EnemyWander>().enabled = false;
            // Deal damage to player
            // Hit box deals damage to player in HitBox Script
            StartCoroutine(AttackCycle());
            // WaitForSeconds in between hits
            //}
        }
        
    }

    IEnumerator EnemyAttack()
    {
        //Turn Hitbox On to detect enemy
        enemyHitBox.SetActive(true);
        //Look at HitBox Script for Damage being called;
        //WaitForSeconds to leave hitbox on
        yield return new WaitForSeconds(attackWait);
        //Turn off hitbox
        enemyHitBox.SetActive(false);
        //WaitForSeconds to not spam button
    }

    IEnumerator AttackCycle()
    {
        while (canAttack == true)
        {
            StartCoroutine(EnemyAttack());
            
            yield return new WaitForSeconds(attackCycleWait);
        }
    }
    
    void OnTriggerExit()
    {
        canAttack = false;
        // Else{
        // EnemyWander
        //}
    }
}
