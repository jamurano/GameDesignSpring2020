using UnityEngine;

public class JemIcon : MonoBehaviour
{
    public GameObject jemIcon;
    void Start()
    {
        jemIcon.SetActive(false);
    }

    public void OnMouseOver()
    {
        jemIcon.SetActive(true);
    }

    public void OnMouseExit()
    {
      jemIcon.SetActive(false);  
    }
}
