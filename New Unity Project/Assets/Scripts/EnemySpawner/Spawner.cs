using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnsFive;
    public Transform[] spawnerPos;

    public int spawnsFiveRandom;

    private int spawnsPosRandom;
    

    public float spawnDelay;
    void Start()
    {
        Invoke("Spawn", spawnDelay);
    }

   public void Spawn()
    {


        //DestroyPickUp();

        spawnsFiveRandom = Random.Range(0, spawnsFive.Length);
        spawnsPosRandom = Random.Range(0, spawnerPos.Length);

        Instantiate(spawnsFive[spawnsFiveRandom], spawnerPos[spawnsPosRandom].position, Quaternion.identity);
        //s CheckObject();
        Invoke("Spawn", spawnDelay);
    }

    //void CheckObject()
    //{
    //    if (spawnsFive[spawnsFiveRandom].gameObject.name == "Grains")
    //    {
    //        FindObjectOfType<TextObject>().ShowObjectGrains();
    //    }

    //    else if (spawnsFive[spawnsFiveRandom].gameObject.name == "Fruits")
    //    {
    //        FindObjectOfType<TextObject>().ShowObjectFruits();
    //    }

    //    else if (spawnsFive[spawnsFiveRandom].gameObject.name == "Dairy")
    //    {
    //        FindObjectOfType<TextObject>().ShowObjectDairy();
    //    }

    //    else if (spawnsFive[spawnsFiveRandom].gameObject.name == "Protein")
    //    {
    //        FindObjectOfType<TextObject>().ShowObjectProtein();
    //    }

    //    else if (spawnsFive[spawnsFiveRandom].gameObject.name == "Vegetables")
    //    {
    //        FindObjectOfType<TextObject>().ShowObjectVegetables();
    //    }
    //}

    //void DestroyPickUp()
    //{
    //    GameObject[] pickUps = GameObject.FindGameObjectsWithTag("Enemy");

    //    foreach (GameObject pickUp in pickUps)
    //    {
    //        Destroy(pickUp);
    //    }
    //}
}
