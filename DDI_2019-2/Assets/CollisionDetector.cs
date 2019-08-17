using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    void Start()
    {
         Debug.Log("Inicio");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision detectada con "+ collision.gameObject.name);
    }
}
