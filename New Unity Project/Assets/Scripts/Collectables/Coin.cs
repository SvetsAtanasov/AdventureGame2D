using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IInteractable
{
    public int coinValue = 5;
    public void DestroyItem()
    {
        Destroy(this.gameObject);
    }
}