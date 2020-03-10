using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    public static bool InventoryIsUp;

    public GameObject inventoryMenuUI;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (InventoryIsUp)
            {
                OpenInventory();
            }
            
            else
            {
                CloseInventory();
            }
        }
    }

    void CloseInventory()
    {
        inventoryMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
    }
    
    void OpenInventory()
    {
        inventoryMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu.GameIsPaused = true;
    }

}