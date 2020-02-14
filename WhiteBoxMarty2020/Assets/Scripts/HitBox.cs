using UnityEngine;

public class HitBox : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<HealthData>())
        {
            other.GetComponent<HealthData>().TakeDamage();
        }
    }
}
