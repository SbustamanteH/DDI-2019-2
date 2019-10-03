using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleporter : MonoBehaviour {

	// Use this for initialization
	private Transform player;
	public Transform loadingBar;
	private bool gazedAt;
	public Terrain terrain;
	float timer;
	public float interactionTime = 2f;
	public float playerHeight = 1.7f;
	public bool toTerrain =  true;
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		loadingBar = GameObject.Find("InteractBar").GetComponent<Transform>();
	}
	public void SetGazedAt(bool gazedAt)
	{
		this.gazedAt = gazedAt;
		if (gazedAt == false){
			timer = 0;
			loadingBar.GetComponent<Image>().fillAmount = timer/interactionTime;
		}
	}
	// Update is called once per frame
	public void TeleportPlayer () {
		if(toTerrain)
		{
		player.position = new Vector3(transform.position.x,terrain.SampleHeight(transform.position)+playerHeight,transform.position.z);
		}
		else
		{
		player.position = transform.position;
		}

		GameObject.Find("Teleporters").GetComponent<Teleporters>().ActivateAll();
		SetGazedAt(false);
		gameObject.SetActive(false);

	}

	void Update(){
		if (gazedAt)
		{
			timer += Time.deltaTime;
			if(timer >= interactionTime){
				TeleportPlayer();
			}
			loadingBar.GetComponent<Image>().fillAmount = timer/interactionTime;
		}
		
	}
}
