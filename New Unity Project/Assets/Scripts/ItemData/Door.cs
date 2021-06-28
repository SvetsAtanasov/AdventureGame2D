using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door: MonoBehaviour
{
    public void Interact(Player player)
    {
        foreach (Item item in player.inventory.items)
        {
            if (item is ItemKey)
            {
                OpenDoor();
            }
        }
    }

    void OpenDoor()
    {
        GetComponent<Collider2D>().enabled = false;
    }
}
