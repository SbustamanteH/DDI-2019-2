using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WaterBehaviour : MonoBehaviour
{
    private Vector3 vector;
    // Start is called before the first frame update
    void Start()
    {
        vector.Set(337, 7, 266);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        Debug.Log("Agua");
        other.gameObject.GetComponent<Transform>().position = vector;
    
    }
}
