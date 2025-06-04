﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public uimanager uiManager;
    
    void Start()
    {
        uiManager.UpdateMoneyText(money.ToString());
    }

    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("No te alcanza");
            return false;

        }
        else
        {

            money += amount;
            uiManager.UpdateMoneyText(money.ToString());
            return true;
        }
    }
}
