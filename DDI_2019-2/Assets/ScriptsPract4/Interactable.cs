using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour 
{
	bool isInsideZone;
	public bool gazedAt;
	public float interactionTime = 2f;
	public float timer;
	public KeyCode interactionKey = KeyCode.I;
	public Transform loadingBar;

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		if(isInsideZone)
		{
			if(Input.GetKeyDown(interactionKey))
			{
				Interact();
			}
		}
	}

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other)
	{
		if(!other.CompareTag("Player"))
			return;
		// Debug.Log("Entraste en la esfera!");
		// rend.material.color = newColor;
		isInsideZone = true;
	}
	public void SetGazedAt(bool value)
	{
		gazedAt = value;
		if(!gazedAt)
		timer = 0f;
		loadingBar.GetComponent<Image>().fillAmount = timer/interactionTime;
	}
	/// <summary>
	/// OnTriggerExit is called when the Collider other has stopped touching the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerExit(Collider other)
	{
		isInsideZone = false;
	}

	public virtual void Interact()
	{
		timer = 0;
		SetGazedAt(false);
	}

}
