using UnityEngine;

public class UseInventoryItem : MonoBehaviour
{
    public GameObject canvas;
    
    public void OnClick()
    {
        canvas.GetComponent<QuickSelectMenu>().lastButtonClicked.GetComponent<UseItem>().OnClick();
        canvas.GetComponent<QuickSelectMenu>().lastButtonClicked = null;
    }
}
