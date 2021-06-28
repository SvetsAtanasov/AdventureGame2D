using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HealthBarManager: MonoBehaviour
{
    public List<FoodHungerBar> foodHungerBars = new List<FoodHungerBar>();

    public void AddFood(FoodType foodType, float value)
    {
       foreach (FoodHungerBar foodHungerBar in foodHungerBars)
        {
            if (foodHungerBar.foodType == foodType)
            {
                foodHungerBar.hungerBar.AddValue(value);
            }
        }
    }

    private void Update()
    {
        foreach (FoodHungerBar foodHungerBar in foodHungerBars)
        {
            if (foodHungerBar.hungerBar.IsEmpty() == true)
            {
                //When player dies //Animation & end game state
                GameOver();
                return; //Once the condition is reached you end method
            }
        }
    }

    void GameOver()
    {
        this.enabled = false; //Disable because it will update ++
        //End game state and death animation logic
    }

    [System.Serializable]
    public class FoodHungerBar
    {
        public FoodType foodType;
        public HungerBar hungerBar;
    }
}
