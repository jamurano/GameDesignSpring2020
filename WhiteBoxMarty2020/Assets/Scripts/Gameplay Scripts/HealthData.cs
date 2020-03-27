using UnityEngine;
using UnityEngine.Events;
public class HealthData : MonoBehaviour
{
    public ObjectDefinition definition;
    public float maxHealth, currentHealth;
    public float healAmount = 10f;

    public UnityEvent deathEvent, onTakeDamageEvent;

    void Start()
    {
        maxHealth = definition.maxHealth;
        currentHealth = maxHealth;
    }

    void Update()
    {
        if(currentHealth <= 0)
        {
            deathEvent.Invoke();
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        onTakeDamageEvent.Invoke();
    }

    public void Heal()
    {
        currentHealth = currentHealth + healAmount;
        onTakeDamageEvent.Invoke();
    }

}