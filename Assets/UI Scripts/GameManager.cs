
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance;
	public Text uiTimer;
	public Button uiButton;

	float timer;
	int level;

	public void Start() {
		Debug.Log("Start");
		if (instance == null)
			instance = this;

		level = 0;
		uiButton.gameObject.SetActive(false);
	}

	public void StartGame() {
		Debug.Log("StartGame");
		level = 1;
		timer = 60f;
	}

	public void NextScene() {
		Debug.Log("NextScene");
		if (level < 3) {
			level += 1;
			timer = 60f;
			uiButton.gameObject.SetActive (false);
		} else {
			EndScene();
		}
	}

	public void Update() {
		if (level > 0 && level < 4) {
			if (timer == 021) {
				uiButton.gameObject.SetActive (true);
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
		//ShowPanels.instance.ShowMenu();
	}


}
