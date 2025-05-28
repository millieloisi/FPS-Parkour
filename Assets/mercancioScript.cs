using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercancioScript : MonoBehaviour
{

    public int precio;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.name ==  "Player")
        {
            Destroy(gameObject);
        }
    }
}
 