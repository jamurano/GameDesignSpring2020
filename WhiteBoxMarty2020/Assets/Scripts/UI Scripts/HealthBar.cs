using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject character;
    
    public void OnHealthChanged()
    {
        GetComponent<Image>().fillAmount = character.GetComponent<HealthData>().currentHealth / character.GetComponent<HealthData>().definition.maxHealth;
    }
}
