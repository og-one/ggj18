﻿
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
	public FaceManager faceManager;


	public GameObject bg;


	float timer;
	int level;

	float startTime = 6f;

	public void Start() {
        playerpositions.positions.Clear();
        playerpositions.list_of_positions.Clear();
        FaceManager.npc_list_of_positions.Clear();
        FaceManager.npc_positions.Clear();


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
		timer = startTime;
		bg.transform.position = new Vector3(bg.transform.position.x, -23f, bg.transform.position.z);
		facecontroller.controllable = true;
	}

	public void NextScene() {


        //adding positions and changing scenes
        if (changecolor.randint < 5)
        {
            changecolor.randint++;
        }else{
            changecolor.randint = 0;
        }
        playerpositions.list_of_positions.Add(playerpositions.positions);
        FaceManager.npc_list_of_positions.Add(FaceManager.npc_positions);


		Debug.Log("NextScene");
		if (level < 4) {
			level += 1;
			timer = startTime;
			uiButton.gameObject.SetActive (false);
			scoreboard.SetActive (false);
			faceManager.loadNextLevel ();
			facecontroller.controllable = true;
		} else if (level == 4) {
			uiButton.gameObject.SetActive(false);
			scoreboard.SetActive(true);
		} else {
			
		}
	}

	public void Update() {
		Debug.Log("Update");
		if (level < 4) {
			if (level > 0 && timer <= 0) {
				uiButton.gameObject.SetActive(true);

				facecontroller.controllable = false;
			} else {
				timer = Mathf.Clamp (timer - Time.deltaTime, 0.0f, 200.0f);
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
