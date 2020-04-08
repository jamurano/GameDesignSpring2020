using UnityEngine;
using UnityEngine.Events;

public class HeartData : MonoBehaviour
{
    public int currentHearts;

    public UnityEvent deathEvent, onLoseHeartEvent;
    
    void Update()
    {
        if(currentHearts <= 0)
        {
            deathEvent.Invoke();
        }
    }

    public void LoseHeart()
    {
        currentHearts--;
        onLoseHeartEvent.Invoke();
    }

    public void Heal()
    {
        currentHearts++;
        onLoseHeartEvent.Invoke();
    }
}
