using System.Collections;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public bool canAttack;
    private GameObject currentEnemy;
    public float attackTime;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            canAttack = true;
            currentEnemy = other.gameObject;
            StartCoroutine(AttackTimer());
        }
        // variable in inspector null even when set
    }
    public void Attack()
    {
        if (Input.GetMouseButtonDown(0) && currentEnemy != null)
        {
            currentEnemy.GetComponent<HealthData>().TakeDamage();

            if (currentEnemy.GetComponent<HealthData>().currentHealth <= 0)
            {
                canAttack = false;
            }
        }
        else
        {
            canAttack = false;
        }
    }

    IEnumerator AttackTimer()
    {
        while(canAttack == true)
        {
            Attack();
            yield return new WaitForSeconds(attackTime);
        }
    }

}