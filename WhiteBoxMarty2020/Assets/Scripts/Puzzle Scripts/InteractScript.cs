using UnityEngine;
using UnityEngine.Events;

public class InteractScript : MonoBehaviour
{
    public bool canInteract = false;

    public GameObject interactableObj;
    public GameObject popUpBox;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Interact")
        {
            popUpBox.SetActive(true);
            interactableObj = other.gameObject;
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        popUpBox.SetActive(false);
        canInteract = false;
    }
    //hello
    public void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            interactableObj.GetComponent<InteractEvent>().interactEvent.Invoke();
        }
    }
}
