using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public InventorySlot slotPrefab;
    public Transform slotHolderTransform;
    private void Start()
    {
        InstatiateSlot();
    }

    void InstatiateSlot()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(slotPrefab, Vector3.zero, Quaternion.identity, slotHolderTransform);
        }
    }
}
