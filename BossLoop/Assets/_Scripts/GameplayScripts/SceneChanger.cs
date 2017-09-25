using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour {

    GameObject[] pauseObjects;

    // Use this for initialization
	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
	}

	// Pause and unpause the game with Return-key
    void Update() {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            pauseControl();
        }
    }

	// Controls the pausing of the scene
	public void pauseControl() {
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0){
                Time.timeScale = 1;
				hidePaused();
			}
	}

	// Reloads the Level
	public void Reload() {
		Application.LoadLevel(Application.loadedLevel);
	}

	// Returns to main menu
	public void Quit() {
		Debug.Log("Quitting... returning to main menu");
        Application.LoadLevel("MenuScene");
	}

	// Show objects (menu items) with ShowOnPause tag
	public void showPaused() {
        Debug.Log ("Show pause menu objects");
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	// Hide objects with ShowOnPause tag
	public void hidePaused() {
        Debug.Log ("Hide pause menu objects");
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}

	// Load first level from main menu
    public void LoadLevel(string name) {
        Debug.Log("Levelid: " + name);
        Application.LoadLevel(name);
    }
}
