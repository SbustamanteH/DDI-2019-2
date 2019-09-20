using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 pressed;
    public GameObject entrance;
    private Vector3 End_pos;
    private Vector3 Start_pos;
    private float distance = 31f;
    private float lerpTime = 5;
    private float currentLerpTime = 0;
    public bool move;

    // Start is called before the first frame update
    void Start()
    {
       Start_pos = entrance.transform.position;
       End_pos = entrance.transform.position + Vector3.up * distance;
        pressed = new Vector3(331,6,268);
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            
            currentLerpTime+=Time.deltaTime;
            if(currentLerpTime>=lerpTime)
            {
                currentLerpTime = lerpTime;
            }
            float perc = currentLerpTime/lerpTime;
            entrance.transform.position = Vector3.Lerp(Start_pos,End_pos,perc);
            transform.position = pressed;
        }

    }
}
