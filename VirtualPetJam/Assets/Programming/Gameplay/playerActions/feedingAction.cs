using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feedingAction : playerActions
{
    #region Events

    public delegate void OnUpdateFood(short food);
    public static event OnUpdateFood onUpdateFood;

    #endregion

    short foodAmount = 5;
    float recoveryTimer = 0;
    float durationRecovery = 10;

    void Update()
    {
        if (foodAmount == 0 && Time.time - durationRecovery > recoveryTimer)
        {
            RecoverFood();
        }
    }

    public void UseFood()
    {
        if (foodAmount > 0)
        {
            foodAmount--;
            if (onUpdateFood != null)
                onUpdateFood(foodAmount);
        }
    }

    void RecoverFood()
    {
        foodAmount = 5;
        if (onUpdateFood != null)
            onUpdateFood(foodAmount);
    }

    public void FeedMonster()
    {
        if (myMonster.getHunger() != 3)
            myMonster.changeMood(1);
        myMonster.changeHunger(3);
    }
}
