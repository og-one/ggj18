
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance;
	public Text uiTimer;
	public Button uiButton;
	public GameObject scoreboard;

	float timer;
	int level;

	public void Start() {
		Debug.Log("Start");
		if (instance == null)
			instance = this;

		level = 0;
		uiButton.gameObject.SetActive(false);
		scoreboard.SetActive(false);
	}

	public void StartGame() {
		Debug.Log("StartGame");
		level = 1;
		timer = 60f;
	}

	public void NextScene() {
		Debug.Log("NextScene");
		if (level < 4) {
			level += 1;
			timer = 60f;
			uiButton.gameObject.SetActive (false);
			scoreboard.SetActive (false);
		} else if (level == 4) {
			uiButton.gameObject.SetActive(false);
			scoreboard.SetActive(true);
		} else {
			
		}
	}

	public void Update() {
		Debug.Log("Update");
		if (level < 4) {
			if (level > 0 && timer == 0) {
				uiButton.gameObject.SetActive(true);
			} else {
				timer = Mathf.Clamp (timer - Time.deltaTime, 0.0f, 2.0f);
				uiTimer.text = "Level " + level.ToString() + ": " + timer.ToString("F2") + " sec";
			}
		} else {
			EndScene();
		}
	}

	public void EndScene() {
		// display end screen
		// fill up progress bars based on score
		// main menu button, quit button
		Debug.Log("End scene");
		scoreboard.gameObject.SetActive(true); 
	}


}
