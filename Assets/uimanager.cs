using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uimanager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;

    // Start is called before the first frame update
    void Start()
    {
        txtMoney.text = "$0";
        txtHealth.text = "HP: 100";

    }

    public void UpdateMoneyText(string moneyAmount)
    {
        txtMoney.text = "$" + moneyAmount;
    }

    public void UpdateHealthText(string HealthPoints)
    {
        txtHealth.text = "HP" + HealthPoints;
    }
}



