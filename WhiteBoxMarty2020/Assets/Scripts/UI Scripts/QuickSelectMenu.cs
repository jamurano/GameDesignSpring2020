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
            if (itemOne != null && quickSelectTextBox.activeSelf == false)
            {
                itemOne.GetComponent<UseItem>().OnClick();
                //destroy gameObject
                Destroy(itemOne);
                itemOne = null;
            }
            
            else if (quickSelectTextBox.activeSelf == true)
            {
                AddToUI(1);
                quickSelectTextBox.SetActive(false);
            }
        }
        
        // use item from second quickSelectSlot
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (itemTwo != null && quickSelectTextBox.activeSelf == false)
            {
                itemTwo.GetComponent<UseItem>().OnClick();
                //destroy gameObject
                Destroy(itemTwo);
                itemOne = null;
            }
            
            else if (quickSelectTextBox.activeSelf == true)
            {
                AddToUI(2);
                quickSelectTextBox.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // use item from third quickSelectSlot
            if (itemThree != null && quickSelectTextBox.activeSelf == false)
            {
                itemThree.GetComponent<UseItem>().OnClick();
                //destroy gameObject
                Destroy(itemThree);
                itemThree = null;
            }
            
            else if (quickSelectTextBox.activeSelf == true)
            {
                AddToUI(3);
                quickSelectTextBox.SetActive(false);
            }
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

        if (slotNumber == 1 && itemOne == null)
        {
            GameObject newButton = Instantiate(buttonToAdd, slotOne.transform.position, Quaternion.identity);
            newButton.transform.SetParent(slotOne.transform);
            itemOne = newButton;
            Destroy(lastButtonClicked);
        }

        if (slotNumber == 2 && itemTwo == null)
        {
            GameObject newButton = Instantiate(buttonToAdd, slotTwo.transform.position, Quaternion.identity);
            newButton.transform.SetParent(slotTwo.transform);
            itemTwo = newButton;
            Destroy(lastButtonClicked);
        }

        if (slotNumber == 3 && itemThree == null)
        {
            GameObject newButton = Instantiate(buttonToAdd, slotThree.transform.position, Quaternion.identity);
            newButton.transform.SetParent(slotThree.transform);
            itemThree = newButton;
            Destroy(lastButtonClicked);
        }
        
        lastButtonClicked = null;
    }
}
