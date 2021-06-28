using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision: MonoBehaviour
{
    private UserInterface userInterface;
    private HealthBarManager healthBarManager;
    private Transform intPoint;

    //void OnTriggerEnter2D(Collider2D collisionItem)
    //{
    //    Food food = collisionItem.GetComponent<Food>();
    //    if (food != null)
    //    {
    //        healthBarManager.AddFood(food.foodType, food.value);
    //        userInterface.ShowGoodJobText();
    //        userInterface.SpawnText(collisionItem.transform.position, food.value);
    //        Destroy(collisionItem.gameObject);
    //    }
    //}

    private void Start()
    {
        userInterface = FindObjectOfType<UserInterface>();
        healthBarManager = FindObjectOfType<HealthBarManager>();
    }
}
