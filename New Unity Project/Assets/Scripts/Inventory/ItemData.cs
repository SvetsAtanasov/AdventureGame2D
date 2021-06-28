using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string itemDescription;

    //[SerializeField] private float itemDamage;

    public Sprite itemSprite;
    public GameObject itemPrefab;
}



