using UnityEngine;

public class InstansiateGameObject : MonoBehaviour
{
    public GameObject obj;
    public void InstansiateGameObj()
    {
        Instantiate(obj);
    }
}
