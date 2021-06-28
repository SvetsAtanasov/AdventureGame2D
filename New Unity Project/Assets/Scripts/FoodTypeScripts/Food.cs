using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food: MonoBehaviour
{
    public string foodName;
    public float value;

    public FoodType foodType;
}

public enum FoodType { Grains, Fruits, Vegetables, Proteins, Dairy }


