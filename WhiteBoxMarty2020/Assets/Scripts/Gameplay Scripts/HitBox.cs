using UnityEngine;

public class HitBox : MonoBehaviour
{
    public int damage;
    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HealthData>())
        {
            other.GetComponent<HealthData>().TakeDamage(damage);
        }

        if (other.GetComponent<KnockBack>())
        {
            //send enemies position
            other.GetComponent<KnockBack>().KnockedBack(transform.parent.parent.gameObject);
        }
    }
}
