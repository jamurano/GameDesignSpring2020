using UnityEngine;
using UnityEngine.Events;

public class ManaData : MonoBehaviour
{
    public ObjectDefinition definition;
    public float maxMana, currentMana;
    public float manaIncreaseAmount = 10f;

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
            GetComponent<AttackScript>().magicIsRunning = false;
        }
    }

    public void ManaDecrease(int decrease)
    {
        manaDecreaseEvent.Invoke();
        currentMana = currentMana - decrease;

    }

    public void ManaIncrease()
    {
        currentMana = currentMana + manaIncreaseAmount;
    }
}
