using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Vector3 startPos;
    public Vector3 endPos;
    public float fraccion;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        fraccion += 0.01f;
        transform.position = Vector3.Lerp(startPos,endPos,fraccion);
    }
}
