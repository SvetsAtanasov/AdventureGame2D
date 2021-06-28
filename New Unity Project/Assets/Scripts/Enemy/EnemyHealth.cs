using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamagable
{
    public int maxEnemyHealth = 100;

    [SerializeField] private int enemyHealth;
    [SerializeField] private EnemyInventory enemyInventory;

    void Start()
    {
        enemyHealth = maxEnemyHealth;
        enemyInventory = GetComponent<EnemyInventory>();
    }

    public void Damage(int damage, IDamageSource source) //Method for damaging the enemy
    {
        enemyHealth -= damage;
        float ranNum = Random.Range(0, 2);
        Debug.Log(ranNum);

        if (enemyHealth <= 0)
        {
            if (enemyInventory == null)
                return;

            enemyInventory.SpawnItem((int)ranNum);
            OnEnemyDeath();
        }
        Debug.Log(enemyHealth);
    }

    void OnEnemyDeath() //Destroys the gameobject to which this script is attached to
    {
        Destroy(this.gameObject);
    }
}
