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
    }
}
