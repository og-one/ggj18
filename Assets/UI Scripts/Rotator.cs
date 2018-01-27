using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public Vector3 speed = new Vector3 (0, 0, 0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localEulerAngles = new Vector3(Time.fixedTime * speed.x,
		Time.fixedTime * speed.y,
		Time.fixedTime * speed.z);
	}
}
