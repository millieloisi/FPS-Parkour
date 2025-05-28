using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccionDeColisiones : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto " + collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}
