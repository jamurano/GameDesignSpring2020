using UnityEngine;

public class PickUp : MonoBehaviour
{
    // pick up LootObj and Destroy gameobject
    public void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
