using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurting : MonoBehaviour
{
    public int damagePoints;
    public HealthManager healthManager;
    
    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            healthManager.UpdateHealth(-damagePoints);

        }
        Debug.Log("Anda");
        return;
    }
}
