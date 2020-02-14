using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public GameObject hitBox;

    public bool attackIsRunning;
    public float hitBoxWait= 1.5f;
    void Update()
    {
        //Get Mouse Click
        if (Input.GetMouseButtonDown(0))
        {
            // Attack
            if (attackIsRunning == false)
            {
                StartCoroutine(Attack());
            }
          
        }
        
    }

    IEnumerator Attack()
    {
        attackIsRunning = true;
        //Turn Trigger On to detect enemy
        hitBox.SetActive(true);
        //WaitForSeconds to leave hitbox on
        yield return new WaitForSeconds(hitBoxWait);
        //Turn off hitbox
        hitBox.SetActive(false);
        attackIsRunning = false;
        //WaitForSeconds to not spam button

    }
}
