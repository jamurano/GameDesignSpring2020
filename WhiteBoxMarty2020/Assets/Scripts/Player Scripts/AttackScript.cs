using System.Collections;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public GameObject hitBox;
    public GameObject hitBoxMagic;

    public bool attackIsRunning;
    public bool magicIsRunning;
    public float hitBoxWait = 1.5f;
    
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
       
       if (Input.GetMouseButtonDown(1))
       {
           // Attack
           if (magicIsRunning == false)
           {
               StartCoroutine(Magic());
           }
       }
   }

   IEnumerator Attack()
        { 
            attackIsRunning = true;
            //Turn Trigger On to detect enemy
            //Look at HitBox Script for Damage being called
            hitBox.SetActive(true);
            //WaitForSeconds to leave hitbox on
            yield return new WaitForSeconds(hitBoxWait);
            //Turn off hitbox
            hitBox.SetActive(false);
            attackIsRunning = false;
            //WaitForSeconds to not spam button
        }

   IEnumerator Magic()
    {
        magicIsRunning = true;
        hitBoxMagic.SetActive(true);
        yield return new WaitForSeconds(hitBoxWait);
        hitBoxMagic.SetActive(false);
        magicIsRunning = false;
    
    }
}

