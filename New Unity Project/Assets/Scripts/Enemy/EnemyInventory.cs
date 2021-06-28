using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInventory : MonoBehaviour
{
    [SerializeField] private ItemData[] inventoryItems;
    [SerializeField] private List<GameObject> prefabs;

    void Start()
    {
        inventoryItems = Resources.LoadAll<ItemData>("Items");
        AddItemsToList();
    }

    void AddItemsToList()
    {
        if (inventoryItems == null)
            return;

        foreach (ItemData inventoryItem in inventoryItems)
        {
            //make it so that it gets added to a list
            prefabs.Add(inventoryItem.itemPrefab);
            Debug.Log(prefabs);
        }
    }

    public void SpawnItem(int ranNum)
    {
        Instantiate(prefabs[ranNum], this.transform.position, Quaternion.identity);
    }
}
