﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceManager : MonoBehaviour {

    public static List<Vector3> npc_positions = new List<Vector3>();
    public static List<List<Vector3>> npc_list_of_positions = new List<List<Vector3>>();//0,1,2

	public GameObject playerPos;

	public GameObject humanFaceGraphics;
	public GameObject elfFaceGraphics;
	public GameObject babyFaceGraphics;
	public GameObject dogFaceGraphics;

	public List<GameObject> FaceParadigm = new List<GameObject>();
	public List<GameObject> FaceBackground = new List<GameObject> ();
	private GameObject currentFaceBackground;
	public GameObject faceBackgroundHolder;

	public List<Vector3> CurrentParadigm = new List<Vector3> ();

	public NewBehaviourScript paradigm; 
	public float score;
	public float finalScore;

    public static List<float> Scores = new List<float>();

	public bool testNextLevel;
	public int testLevel;

//	public List<Vector3> Eye_Right; 
//	public List<Vector3> Eye_Left; 
//	public List<Vector3> EyeBrow_Right_1; 
//	public List<Vector3> EyeBrow_Right_2; 
//	public List<Vector3> EyeBrow_Right_3;
//	public List<Vector3> EyeBrow_Left_1;  
//	public List<Vector3> EyeBrow_Left_2; 
//	public List<Vector3> EyeBrow_Left_3;  
//	public List<Vector3> Mouth_1; 
//	public List<Vector3> Mouth_2; 
//	public List<Vector3> Mouth_3; 
//	public List<Vector3> Mouth_4; 
//	public List<Vector3> Mouth_5; 
//	public List<Vector3> Mouth_6; 


	public void LoadLevel(int level)
	{
        Scores.Add(score / finalScore);
        foreach(GameObject x in randomPersonsFace){
            npc_positions.Add(x.transform.position);
        }
        npc_list_of_positions.Add(npc_positions);
		// load the graphics
		//if(level == 1)
		facecontroller[] playerTransforms = playerPos.GetComponentsInChildren<facecontroller> ();
		for (int i = 0; i < playerTransforms.Length; i++)
		{
			playerTransforms [i].transform.position = playerTransforms [i].origin;
		}

		// Change the face paradigm that you compare to
		CurrentParadigm.Clear ();
		foreach (Collider c in FaceParadigm [level].GetComponentsInChildren<Collider> ()) {
			CurrentParadigm.Add (c.transform.localPosition);
		}
		if (level > 0) {
			FaceParadigm [level - 1].SetActive(false);
		}
		currentFaceBackground.SetActive (false);
		currentFaceBackground = Instantiate (FaceBackground [testLevel]);
		currentFaceBackground.transform.parent = faceBackgroundHolder.transform;
		currentFaceBackground.transform.localPosition = new Vector3 (0, 0, 0);
		currentFaceBackground.transform.localEulerAngles = new Vector3 (0, 0, 0);
		currentFaceBackground.transform.localScale = new Vector3 (1, 1, 1);
	}

	// Use this for initialization
	void Start () {

		paradigm = (NewBehaviourScript)ScriptableObject.CreateInstance (typeof(NewBehaviourScript)); 

		//Instatiate face graphics
		//GameObject go =  Instatiate( humanFaceGraphics) as GameObject;
		//playerPos

		//AAfter every time we change level 
		CurrentParadigm.Clear ();
		foreach (Collider c in FaceParadigm [0].GetComponentsInChildren<Collider> ()) {
			CurrentParadigm.Add (c.transform.localPosition);
		}

		//Set up final score 
		Collider[] playerTransforms = playerPos.GetComponentsInChildren<Collider> ();
		finalScore = 0;
		for (int i = 0; i < CurrentParadigm.Count; i++)
		{
			finalScore += Vector3.Distance (playerTransforms[i].transform.localPosition, CurrentParadigm[i]);
		}
		testLevel = 0;

		currentFaceBackground = Instantiate (FaceBackground [testLevel]);
		currentFaceBackground.transform.parent = faceBackgroundHolder.transform;
		currentFaceBackground.transform.localPosition = new Vector3 (0, 0, 0);
		currentFaceBackground.transform.localEulerAngles = new Vector3 (0, 0, 0);
		currentFaceBackground.transform.localScale = new Vector3 (1, 1, 1);
	}
		

	public GameObject[] happy;
	public GameObject[] upset;
	public GameObject[] randomPersonsFace;
	public float test;
	void OthersFace()
	{
		for(int i = 0; i < happy.Length; i++)
		{
			randomPersonsFace[i].transform.localPosition = Vector3.Lerp(happy[i].transform.localPosition,upset[i].transform.localPosition,score / finalScore);
		}
	}

	// Update is called once per frame
	void Update () {
		
		//scoring
		Collider[] playerTransforms = playerPos.GetComponentsInChildren<Collider> ();
		//Check at the end 
		score = 0;
		for (int i = 0; i < CurrentParadigm.Count; i++)
		{
			score += Vector3.Distance (playerTransforms[i].transform.localPosition, CurrentParadigm[i]);
		}

		if(testNextLevel)
		{
			loadNextLevel ();
			testNextLevel = false;
		}
		
		OthersFace();
//		if(Input.a)
	}

	public void loadNextLevel() {
		testLevel++;
		LoadLevel (testLevel);
	}
}
