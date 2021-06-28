using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour,IDamageSource
{
    public Inventory inventory;
    public PlayerController controller;
    public PlayerHealth playerHealth;

    private void Start()
    {
        inventory = GetComponent<Inventory>();
        controller = GetComponent<PlayerController>();
        playerHealth = GetComponent<PlayerHealth>();
    }


}
