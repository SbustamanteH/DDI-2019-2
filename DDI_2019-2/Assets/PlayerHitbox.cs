using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    public Transform cam;
    Vector3 left;
    Vector3 right;
    Vector3 center;
    
    public SphereCollider col;
    // Start is called before the first frame update
    void Start()
    {
        left = new Vector3(-0.6f,0,0);
        right = new Vector3(0.6f,0,0);
        center = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
