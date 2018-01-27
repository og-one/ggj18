
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance;
	private ShowPanels showPanels;
	public Text uiTimer;
	public Button uiButton;

	float timer;
	int level = 0;

	public void Start()
	{
		if (instance == null)
			instance = this;

		level += 1;
		timer = 1f;
		uiButton.gameObject.SetActive(false);
	}

	public void StartGame()
	{
		Debug.Log("Start game");
		timer = 10.0f;	
	}

	public void NextScene()
	{
		Debug.Log ("Next Scene");
	}

	public void Update()
	{
		// link time to the UI Text Element
		timer -= Time.deltaTime;
		timer = Mathf.Clamp(timer, 0.0f, 5.0f);
		uiTimer.text = timer.ToString();

		if (timer <= 0)
		{
			//hide level
			if (level < 3)
			{
				uiButton.gameObject.SetActive(true);
			} else 
			{
				EndScene();
			}
		}
	}

	public void EndScene()
	{
		// display end screen
		// fill up progress bars based on score
		// main menu button, quit button
	}


}
