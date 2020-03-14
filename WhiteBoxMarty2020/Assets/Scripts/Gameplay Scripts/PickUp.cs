using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject inventory;
    public pickUpType pickUps;
    public enum pickUpType
    {
        COINS, HEALTH, MANA
    }

    public void TalkToInventory()
    {
        // find inventory object after picking up object
        inventory = GameObject.Find("Canvas");
        // tell inventory object what object it is
        inventory.GetComponent<InventoryUI>().InventoryManager(gameObject);
        // let inventory object figure out how to add object to itself
    }

}
