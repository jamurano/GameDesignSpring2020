using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ManaData : MonoBehaviour
{
    public ObjectDefinition definition;
    public float maxMana, currentMana;
    public float manaIncreaseAmount = 10f;
    
    public float refillManaWait;
    private bool refillIsRunning = false;

    public UnityEvent manaDecreaseEvent;

    void Start()
    {
        maxMana = definition.maxMana;
        currentMana = maxMana;
    }

    void Update()
    {
        if (currentMana <= 0)
        { 
            //disable magic use
            GetComponent<AttackScript>().canUseMagic = false;
        }
    }

    public void ManaDecrease(int decrease)
    {
        currentMana = currentMana - decrease;
        manaDecreaseEvent.Invoke();
        if (!refillIsRunning)
        {
            StartCoroutine(SlowlyRefillMana());
        }
    }

    public void ManaIncrease()
    {
        currentMana = currentMana + manaIncreaseAmount;
        GetComponent<AttackScript>().canUseMagic = true;
        manaDecreaseEvent.Invoke();
    }
    
    public IEnumerator SlowlyRefillMana()
    {
        refillIsRunning = true;
        while (currentMana < maxMana)
        {
            manaDecreaseEvent.Invoke();
            currentMana++;
            yield return new WaitForSeconds(refillManaWait);
        }

        refillIsRunning = false;
    }
}
