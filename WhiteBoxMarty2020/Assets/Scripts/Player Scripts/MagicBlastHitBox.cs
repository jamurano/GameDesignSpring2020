using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBlastHitBox : MonoBehaviour
{
    public int damage;
    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HealthData>())
        {
            other.GetComponent<HealthData>().TakeDamage(damage);
            print(gameObject);
            Destroy(gameObject);
        }
    }
}
