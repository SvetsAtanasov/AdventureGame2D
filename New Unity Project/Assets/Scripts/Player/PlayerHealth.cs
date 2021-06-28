using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth: MonoBehaviour, IDamagable
{
    public int maxPlayerHealth = 100;

    private int playerHealth;

    void Start()
    {
        playerHealth = maxPlayerHealth;
    }

    public void Damage(int damage, IDamageSource source)
    {
        playerHealth -= damage;
        Debug.Log(playerHealth);

        if (playerHealth == 0)
        {
            //Animation
            Destroy(this.gameObject, 2f); //current player death state
        }
    }
}
