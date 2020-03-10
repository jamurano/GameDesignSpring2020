using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    public static bool InventoryIsUp = false;

    public GameObject inventoryMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
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
        inventoryMenuUI.SetActive(false);
        Time.timeScale = 1f;
        InventoryIsUp = false;
        PauseMenu.GameIsPaused = false;
    }
    
    void OpenInventory()
    {
        inventoryMenuUI.SetActive(true);
        Time.timeScale = 0f;
        InventoryIsUp = true;
        PauseMenu.GameIsPaused = true;
    }

}