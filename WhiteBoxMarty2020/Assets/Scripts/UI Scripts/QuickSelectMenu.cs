using UnityEngine;

public class QuickSelectMenu : MonoBehaviour
{
    public GameObject slotOne, slotTwo, slotThree;
    public GameObject itemOne, itemTwo, itemThree;

    public GameObject quickSelectTextBox;
    public GameObject lastButtonClicked;
    public GameObject buttonToAdd;

    public GameObject manaButton, healthButton;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // use item from first quickSelectSlot
            if (itemOne != null)
            {
                itemOne.GetComponent<UseItem>().OnClick();
                //destroy gameObject
                Destroy(itemOne);
                itemOne = null;
            }
            
            else if (quickSelectTextBox.activeSelf == true)
            {
                AddToUI(1);
            }

            // Increase either Mana or Health amount
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // use item from second quickSelectSlot
            //destroy gameObject
            // Increase either Mana or Health amount
        }

        if (Input.GetKeyDown((KeyCode.Alpha3)))
        {
            // use item from third quickSelectSlot
            //destroy gameObject
            // Increase either Mana or Health amount
        }
    }

    public void AddToUI(int slotNumber)
    {
        if (lastButtonClicked.GetComponent<PickUp>().pickUps == PickUp.pickUpType.MANA)
        {
            buttonToAdd = manaButton;
        }
        
        if (lastButtonClicked.GetComponent<PickUp>().pickUps == PickUp.pickUpType.HEALTH)
        {
            buttonToAdd = healthButton;
        }

        if (slotNumber == 1)
        {
            GameObject newButton = Instantiate(buttonToAdd, slotOne.transform.position, Quaternion.identity);
            newButton.transform.SetParent(slotOne.transform);
        }
        
        Destroy(lastButtonClicked);
        lastButtonClicked = null;
    }
}
