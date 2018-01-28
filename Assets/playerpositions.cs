using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpositions : MonoBehaviour {
    public static List<Vector3> positions = new List<Vector3>();
    public static List<List<Vector3>> list_of_positions = new List<List<Vector3>>();
	public GameObject Eye_Right; 
	public GameObject Eye_Left; 
	public GameObject EyeBrow_Right_1; 
	public GameObject EyeBrow_Right_2; 
	public GameObject EyeBrow_Right_3;
	public GameObject EyeBrow_Left_1;  
	public GameObject EyeBrow_Left_2; 
	public GameObject EyeBrow_Left_3;  
	public GameObject Mouth_2; 
	public GameObject Mouth_3; 
	public GameObject Mouth_4; 
	public GameObject Mouth_5; 
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		positions = new List<Vector3>{ 
			Eye_Right.transform.position,
			Eye_Left.transform.position, 
			EyeBrow_Right_1.transform.position,
			EyeBrow_Right_2.transform.position,
			EyeBrow_Right_3.transform.position,
			EyeBrow_Left_1.transform.position,
			EyeBrow_Left_2.transform.position,
			EyeBrow_Left_3.transform.position,
			Mouth_2.transform.position,
			Mouth_3.transform.position,
			Mouth_4.transform.position,
			Mouth_5.transform.position
		};
	}

	public void click(){
		list_of_positions.Add (positions);
	}
}
