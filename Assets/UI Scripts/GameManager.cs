
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
	int level = 3;

	public void Start()
	{
		if (instance == null)
			instance = this;

		level += 1;
		Debug.Log("Start");
		uiButton.gameObject.SetActive(false);
	}

	public void StartGame()
	{
		level = 1;
		timer = 60f;
		uiButton.gameObject.SetActive(false);
		Debug.Log("Start game");
	}

	public void NextScene()
	{
		if (level < 3) {
			level += 1;
			timer = 60f;
			uiButton.gameObject.SetActive (false);
		} else {
			EndScene();
		}
	}

	public void Update()
	{
		if (timer == 0) {
			Debug.Log (timer);
			//hide level
			if (level < 4) {
				uiButton.gameObject.SetActive(true);
			}
		} else {
			timer -= Time.deltaTime;
			timer = Mathf.Clamp (timer, 0.0f, 5.0f);
			uiTimer.text = "Level " + level.ToString () + ": " + timer.ToString("F2") + " sec";
		}

	}

	public void EndScene()
	{
		// display end screen
		// fill up progress bars based on score
		// main menu button, quit button
		Debug.Log("End scene");
		level = 0;
		timer = 0f;
	}


}
