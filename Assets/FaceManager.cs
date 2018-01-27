using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceManager : MonoBehaviour {


	public GameObject playerPos;

	public List<GameObject> FaceParadigm = new List<GameObject>();

	public List<Vector3> CurrentParadigm = new List<Vector3> ();

	public NewBehaviourScript paradigm; 

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


		Transform[] playerTransforms = playerPos.GetComponentsInChildren<Transform> ();
		//Check at the end 
		for (int i = 0; i < CurrentParadigm.Count; i++)
		{
			Vector3.Distance (playerTransforms [i].position, CurrentParadigm[i]);
		}
			


	}

	// This function is to compare the coordinates of the players with the paradigm 
	void Compare(){
//		PlayerCoordinates = GameObject.FindGameObjectsWithTag ("Player");
//		foreach (GameObject p in PlayerCoordinates)
//			p.transform.position()
	}


	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButton(0))
		{
			Debug.Log ("Testing Update");	
//			Physics.Raycast;
		}

//		if(Input.a)
	}
}
