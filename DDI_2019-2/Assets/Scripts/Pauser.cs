using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;



public class Pauser : MonoBehaviour {
	private bool paused = false;
	public GameObject pauseMenu;
	public GameObject gameHUD;
	public FirstPersonController controller;
	public bool inventoryOpen = false;
	
	
	// Update is called once per frame

	
	void Update () {
		if(Input.GetKeyUp(KeyCode.P))
		{
			paused = !paused;
	
		}

		if(paused){
			Time.timeScale = 0;
			pauseMenu.SetActive(true);
			gameHUD.SetActive(false);
			controller.CursorLock(false);

		}

		else if(inventoryOpen){
			controller.CursorLock(false);
		}
		else{
			Time.timeScale = 1;
			pauseMenu.SetActive(false);
			gameHUD.SetActive(true);
			controller.CursorLock(true);
		}

			
			
	}
	public void ContinueGame()
	{
	paused = false;
	}


	public void RestartLevel()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}


