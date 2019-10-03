using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryUI : MonoBehaviour 
{
	public Transform player;
	public Transform canvas;
	public GameObject inventoryPanel;
	private Inventory inventory;
	public FirstPersonController controller;
	public Pauser pauser;

	//VR interaction
	public bool gazedAt;
	public float interactionTime = 2f;
	public float timer;
	public Transform loadingBar;


	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{

		loadingBar = GameObject.Find("InteractBar").GetComponent<Transform>();

		inventory = FindObjectOfType<Inventory>();
		if (inventory == null)
		{
			Debug.LogWarning("No se encontró el Inventario");
			return;
		} 
		inventoryPanel.SetActive(false);
		inventory.onItemChange += UpdateUI;
	}

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Q))
		{
			Debug.Log("UI Off");
			inventoryPanel.SetActive(!inventoryPanel.activeSelf);
			pauser.inventoryOpen = inventoryPanel.activeSelf;
			UpdateUI();
		}

		//VR gaze interaction
		
		if (gazedAt)
		{
			timer += Time.deltaTime;
			if(timer >= interactionTime){
				VRinventory();
			}
			loadingBar.GetComponent<Image>().fillAmount = timer/interactionTime;
		}

	}

	public void VRinventory()
	{
			inventoryPanel.SetActive(!inventoryPanel.activeSelf);
			SetGazedAt(false);
			UpdateUI();
	}

	public void SetGazedAt(bool value)
	{
		gazedAt = value;
		if(!gazedAt)
		timer = 0f;
		loadingBar.GetComponent<Image>().fillAmount = timer/interactionTime;
	}
	void UpdateUI()
	{
		Slot[] slots = GetComponentsInChildren<Slot>();
		for (int i = 0; i < slots.Length; i++)
		{
			if(i < inventory.items.Count)
			{
				slots[i].AddItem(inventory.items[i]);
			}
			else
			{
				slots[i].ClearSlot();
			}
		}
	}
}
