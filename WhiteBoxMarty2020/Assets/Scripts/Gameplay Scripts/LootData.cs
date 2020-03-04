using System;
using UnityEngine;
using Random = System.Random;

public class LootData : MonoBehaviour
{
    public LootObjects lootManager;

    public void LootDrop()
    {
        // random.range of loot objs will instantiate 
        int lootIndex = UnityEngine.Random.Range(0, lootManager.lootObjs.Count);
        //Instantiate(LootObjects.)
        Instantiate(lootManager.lootObjs[lootIndex], transform.position, Quaternion.identity);
    }
}
