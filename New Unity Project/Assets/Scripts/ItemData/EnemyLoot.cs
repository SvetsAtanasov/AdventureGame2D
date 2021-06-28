using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLoot: MonoBehaviour
{
    public GameObject[] lootList;

    public void DropItemHighChance(Vector2 enemyPos)
    {
       Instantiate(lootList[0], enemyPos, Quaternion.identity);
    }
}
