using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject healthImage, manaImage, coinImage;

    public PickUp.pickUpType pickUpType;
    public List<GameObject> inventorySlots;
    public List<GameObject> inventoryButtons;
    
    public GameObject healthButtonPrefab;
    public GameObject manaButtonPrefab;
    public GameObject inventoryUI;

    public int coinCounter = 0;
    public Text coinUI;

    public void InventoryManager(GameObject pickUp)
    {
        //find out from PickUp what object it is
        pickUpType = pickUp.GetComponent<PickUp>().pickUps;
        //turn on correlating image and value into InventorySlot
        AddToInventory(pickUpType);
    }

    public void BuyPotion(GameObject potion)
    {
        if (coinCounter >= 25)
        {
            coinCounter -= 25;
            //find out from PickUp what object it is
            pickUpType = potion.GetComponent<PickUp>().pickUps;
            //turn on correlating image and value into InventorySlot
            AddToInventory(pickUpType);
        }
    }

    public void AddToInventory(PickUp.pickUpType type)
    {
        if (type == PickUp.pickUpType.COINS)
        {
            coinCounter+= 5;
            coinUI.text = coinCounter.ToString();
            return;
        }
        //index is temp variable, that tells us where in the list we want to add next item
        int index = 0;
        // looping through inventory buttons list to find empty slot
        for (int i = 0; i < inventoryButtons.Count; i++)
        {
            //if we find empty slot
            if (inventoryButtons[i] == null)
            {
                //index is = the empty slot found
                index = i;
                // stops the loop from continuing to search for empty slot
                break;
            }
        }
        
        if (inventoryButtons[index] == null)
        {
            //temp variable that stores what prefab we want to put in the slot
            GameObject buttonToAdd = null;
            //if pickup is mana, then use mana prefab
            if (type == PickUp.pickUpType.MANA)
            {
                //Do mana stuff
                buttonToAdd = manaButtonPrefab;
                // instantiate prefab and place it in inventory
                inventoryButtons[index] = Instantiate(buttonToAdd, inventorySlots[index].transform.position, Quaternion.identity);
                //making prefab appear in inventory menu
                inventoryButtons[index].transform.SetParent(inventoryUI.transform);
            }
            //if pickup is health, then use health prefab
            if (type == PickUp.pickUpType.HEALTH)
            {
                //Do health stuff
                buttonToAdd = healthButtonPrefab;
                // instantiate prefab and place it in inventory
                inventoryButtons[index] = Instantiate(buttonToAdd, inventorySlots[index].transform.position, Quaternion.identity);
                //making prefab appear in inventory menu
                inventoryButtons[index].transform.SetParent(inventoryUI.transform);
            }
        }
    }
}
