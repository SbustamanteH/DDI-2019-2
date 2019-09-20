using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public Movement movement;
    public Material[] materials;
    Renderer renderer;
    bool interact = false;
    
    Transform entranceTransform;
    



   
    void Start()
    {
        movement = this.GetComponent<Movement>();
        Debug.Log("Inicio");
        renderer = GameObject.Find("Symbol").GetComponent<Renderer>();
        renderer.sharedMaterial = materials[0];
        entranceTransform = GameObject.Find("Entrance").GetComponent<Transform>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && interact)
        {
            movement.move = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            renderer.sharedMaterial = materials[1];
            interact = true;

        }
        
        
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            renderer.sharedMaterial = materials[0];
            interact = false;
        }
        
    }

    


       

}
