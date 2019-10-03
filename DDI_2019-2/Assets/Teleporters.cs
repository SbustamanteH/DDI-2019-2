using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporters : MonoBehaviour
{

    public GameObject[] teleporters;
    public GameObject player;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        teleporters = GameObject.FindGameObjectsWithTag("Teleporter");
        
    }

    public void ActivateAll()
    {
        foreach(GameObject teleporter in teleporters)
        {
            distance = Vector3.Distance(teleporter.transform.position,player.transform.position);
            if(!teleporter.activeSelf)
            if(distance <30f)
            teleporter.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject teleporter in teleporters)
        {
            distance = Vector3.Distance(teleporter.transform.position,player.transform.position);
            if(distance >30f)
            teleporter.SetActive(false);
        }
    }
}
