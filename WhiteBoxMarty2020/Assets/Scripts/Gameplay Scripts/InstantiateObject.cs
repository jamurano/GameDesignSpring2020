using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject deathParticlePrefab;

    public void InstantiateObj()
    {
        Instantiate(deathParticlePrefab, transform.position, transform.rotation);
    }
}
