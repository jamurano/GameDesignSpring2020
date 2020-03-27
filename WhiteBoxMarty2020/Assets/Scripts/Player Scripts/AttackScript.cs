using System.Collections;
using UnityEngine;
using UnityEngine.Animations;

public class AttackScript : MonoBehaviour
{
    public GameObject hitBox;
    public GameObject magicInstantiationPoint;
    public GameObject magicBlastPrefab;

    public bool attackIsRunning;
    public bool magicIsRunning;
    public bool canUseMagic = true;
    
    public float hitBoxWait = .5f;
    public float magicWait = .5f;

    public Animator weaponAnim;

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
       
       if (Input.GetKeyDown(KeyCode.K) && canUseMagic)
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
            //Run attackingAnim animation
            weaponAnim.SetTrigger("attackingAnim");
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
        GetComponent<ManaData>().ManaDecrease(5);
        yield return new WaitForSeconds(magicWait);
        magicIsRunning = false;
    
    }
}

