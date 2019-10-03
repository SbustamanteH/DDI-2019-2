using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : Interactable 
{
	public Item item;
	private Inventory inventory;
	

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		inventory = FindObjectOfType<Inventory>();
		loadingBar = GameObject.Find("InteractBar").GetComponent<Transform>();
		if (inventory == null)
		{
			Debug.LogWarning("No se encontró el Inventario");
			
		}
	}

	public override void Interact()
	{
		base.Interact();
		//Pick up object, add to inventory
		Debug.Log("Levantando Item " + item.name);
		if(item.itemType == ItemType.Immidiate)
		{
			item.Use();
		}
		else
		{
			inventory.Add(item);
		}
		Destroy(this.gameObject);
	}
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
}
