using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    Vector3 buttonStart_pos;
    Vector3 buttonEnd_pos;


    //VR interaction
    float timer;
    public float interactionTime = 2f;
    bool gazedAt;
    public Transform loadingBar;

    // Start is called before the first frame update
    void Start()
    {
       Start_pos = entrance.transform.position;
       End_pos = entrance.transform.position + Vector3.up * distance;
       buttonStart_pos = transform.position;
       buttonEnd_pos = new Vector3(332,transform.position.y,transform.position.z);


       loadingBar = GameObject.Find("InteractBar").GetComponent<Transform>();
    }

    public void SetGazedAt(bool value)
    {
        gazedAt = value;
        if (gazedAt == false)
			timer = 0;
        loadingBar.GetComponent<Image>().fillAmount = timer/interactionTime;
    }

    public void Interact()
    {
        move = true;
        SetGazedAt(false);
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
            transform.position = Vector3.Lerp(buttonStart_pos,buttonEnd_pos,perc);
           

        }

        if (gazedAt)
		{
			timer += Time.deltaTime;
			if(timer >= interactionTime){
				Interact();
			}
            loadingBar.GetComponent<Image>().fillAmount = timer/interactionTime;
		}

    }
}
