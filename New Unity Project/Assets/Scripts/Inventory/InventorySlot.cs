using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public int maxStackSize = 50; 

    public List<GameObject> storedPrefabs;
    public Image slotSprite;
    public Text slotText;

    void SetSlotParameters(Image _slotSprite, Text _slotText)
    {
        slotSprite = _slotSprite;
        slotText = _slotText;
    }

    public void StoreItem(GameObject prefab)
    {

        if (storedPrefabs.Count >= maxStackSize)
        {
            Debug.Log("Slot is full");
        }

        else
        {
            storedPrefabs.Add(prefab);
        }
    }
}