using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public uimanager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateHealthText(healthPoints.ToString());
    }

    // Update is called once per frame
    public void UpdateHealth(int damageAmount)
    {
        if (healthPoints + damageAmount <= 0)
        {
            Debug.Log("Game Over");
            return;

        }

        healthPoints += damageAmount;
        uiManager.UpdateHealthText(healthPoints.ToString());
    }
}
