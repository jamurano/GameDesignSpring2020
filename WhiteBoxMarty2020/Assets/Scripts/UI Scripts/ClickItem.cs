using UnityEngine;

public class ClickItem : MonoBehaviour
{
    public GameObject canvas;
    
    public void OnClick()
    {
        canvas = GameObject.Find("Canvas"); 
        canvas.GetComponent<QuickSelectMenu>().lastButtonClicked = gameObject;
        canvas.GetComponent<QuickSelectMenu>().quickSelectTextBox.SetActive(true);
    }
}
