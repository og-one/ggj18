using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceManager : MonoBehaviour {


	public GameObject playerPos;

	public List<GameObject> FaceParadigm = new List<GameObject>();

	public List<Vector3> CurrentParadigm = new List<Vector3> ();

	public NewBehaviourScript paradigm; 
	public float score;
	public float finalScore;

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


	// Use this for initialization
	void Start () {

		paradigm = (NewBehaviourScript)ScriptableObject.CreateInstance (typeof(NewBehaviourScript)); 

		//AAfter every time we change level 
		CurrentParadigm.Clear ();
		foreach (Transform t in FaceParadigm [0].GetComponentsInChildren<Transform> ()) {
			CurrentParadigm.Add (t.position);
		}

		//scoring
		Transform[] playerTransforms = playerPos.GetComponentsInChildren<Transform> ();
		finalScore = 0;
		for (int i = 0; i < CurrentParadigm.Count; i++)
		{
			finalScore += Vector3.Distance (playerTransforms [i].position, CurrentParadigm[i]);
		}
	}

	// This function is to compare the coordinates of the players with the paradigm 
	void Compare(){
//		PlayerCoordinates = GameObject.FindGameObjectsWithTag ("Player");
//		foreach (GameObject p in PlayerCoordinates)
//			p.transform.position()
	}


	public GameObject[] happy;
	public GameObject[] upset;
	public GameObject[] randomPersonsFace;
	public float test;
	void OthersFace()
	{
		for(int i = 0; i < happy.Length; i++)
		{
			randomPersonsFace[i].transform.position = Vector3.Lerp(happy[i].transform.position,upset[i].transform.position,score / finalScore);
		}
	}

	// Update is called once per frame
	void Update () {
		
		//scoring
		Transform[] playerTransforms = playerPos.GetComponentsInChildren<Transform> ();
		//Check at the end 
		score = 0;
		for (int i = 0; i < CurrentParadigm.Count; i++)
		{
			score += Vector3.Distance (playerTransforms [i].position, CurrentParadigm[i]);
		}
		
		
		OthersFace();
//		if(Input.a)
	}
}
