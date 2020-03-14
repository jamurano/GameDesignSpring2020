using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    public static bool InventoryIsUp = false;
    public bool inventoryIsOpen = false;

    public GameObject inventoryMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryIsUp)
            {
                CloseInventory();
            }
            else
            {
                OpenInventory();
            }
        }
    }

    void CloseInventory()
    {
        inventoryIsOpen = false;
        inventoryMenuUI.SetActive(false);
        InventoryIsUp = false;

    }
    
    void OpenInventory()
    { 
        inventoryIsOpen = true;
        inventoryMenuUI.SetActive(true);
        InventoryIsUp = true;
 
    }

}