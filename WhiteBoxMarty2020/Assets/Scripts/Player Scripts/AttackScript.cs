using System.Collections;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public GameObject hitBox;
    public GameObject magicInstantiationPoint;
    public GameObject magicBlastPrefab;

    public bool attackIsRunning;
    public bool magicIsRunning;
    public float hitBoxWait = .5f;
    public float magicWait = .5f;
    
   void Update()
   {
       //Get Mouse Click
       if (Input.GetKeyDown(KeyCode.J))
       {
           // Attack
           if (attackIsRunning == false)
           {
               StartCoroutine(Attack());
           }

       } 
       
       if (Input.GetKeyDown(KeyCode.K))
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
        Instantiate(magicBlastPrefab, magicInstantiationPoint.transform.position, transform.rotation);
        yield return new WaitForSeconds(magicWait);
        magicIsRunning = false;
    
    }
}

