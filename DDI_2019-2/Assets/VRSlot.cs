﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRSlot : Interactable
{
    
    // Start is called before the first frame update
    void Start()
    {
        loadingBar = GameObject.Find("InteractBar").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
          if (gazedAt)
		{
			timer += Time.deltaTime;
			if(timer >= interactionTime){
				Interact();
			}
			loadingBar.GetComponent<Image>().fillAmount = timer/interactionTime;
		}
    }
    public override void Interact()
    {
        base.Interact();
        GetComponent<Slot>().UseItem();
    }
}