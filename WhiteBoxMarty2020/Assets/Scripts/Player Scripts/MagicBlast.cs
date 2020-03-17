using System;
using UnityEngine;

public class MagicBlast : MonoBehaviour
{
    public float speed = 3f;
    public float destroyTimer = 3f;

    public void Start()
    {
        Destroy(gameObject, destroyTimer);
    }

    public void Update()
    {
        transform.position += transform.forward * speed;
    }
}
