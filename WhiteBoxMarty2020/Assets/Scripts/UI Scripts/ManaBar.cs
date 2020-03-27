using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public GameObject character;
    
    public void OnManaChanged()
    {
        GetComponent<Image>().fillAmount = character.GetComponent<ManaData>().currentMana / character.GetComponent<ManaData>().definition.maxMana;
    }
}
