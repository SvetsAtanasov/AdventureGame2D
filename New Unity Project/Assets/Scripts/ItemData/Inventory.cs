using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory: MonoBehaviour
{
    public int maxSpace = 20;
    public List<Item> items = new List<Item>();

    public bool AddItem(Item item)
    {
        if (items.Count >= maxSpace)
        {
            Debug.Log("Not enough space");
            return false;
        }

        items.Add(item);
        item.transform.SetParent(this.transform);
        item.gameObject.SetActive(false);
        return true;
    }

    public bool DropItem(Item item)
    {
        if (items.Contains(item) == false)
        {
            Debug.LogError("Dropped item is not in inventory");
            return false;
        }

        items.Remove(item);
        item.transform.SetParent(null);
        item.gameObject.SetActive(true);
        return true;

    }
}
