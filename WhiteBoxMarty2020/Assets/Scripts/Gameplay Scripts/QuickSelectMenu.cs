using UnityEngine;

public class QuickSelectMenu : MonoBehaviour
{
    public GameObject healthImage, manaImage, coinImage;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            // use item from first quickSelectSlot
            //destroy gameObject
            // Increase either Mana or Health amount
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // use item from second quickSelectSlot
            //destroy gameObject
            // Increase either Mana or Health amount
        }

        if (Input.GetKeyDown((KeyCode.Alpha2)))
        {
            // use item from third quickSelectSlot
            //destroy gameObject
            // Increase either Mana or Health amount
        }
    }
}
