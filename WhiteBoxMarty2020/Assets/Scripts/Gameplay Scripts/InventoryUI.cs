using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject healthImage;

    public GameObject manaImage;

    public GameObject CoinImage;

    public PickUp.pickUpType pickUpType;

    public void InventoryManager(GameObject pickUp)
    {
        //find out from PickUp what object it is
        pickUpType = pickUp.GetComponent<PickUp>().pickUps;
        //turn on correlating image and value into InventorySlot
        if (pickUpType == PickUp.pickUpType.MANA)
        {
            manaImage.SetActive(true);
        }

        if (pickUpType == PickUp.pickUpType.COINS)
        {
            CoinImage.SetActive(true);
        }

        if (pickUpType == PickUp.pickUpType.HEALTH)
        {
            healthImage.SetActive(true);
        }
        //input.getkey("e") enables and disables Inventory
    }

}
