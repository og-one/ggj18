using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour {
	
	public Transform obj;

	public Vector3 offset = new Vector3(0,0,0);
	public Vector3 rotation = new Vector3 (0, 0, 0);
	public int copies = 3;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < copies; i++) {
			var inst = Instantiate (obj, new Vector3(0,0,0), Quaternion.identity);
			inst.transform.parent = transform;
			inst.transform.localPosition = offset * i;
			inst.transform.localEulerAngles = rotation * i;
			inst.transform.localScale = new Vector3 (1, 1, 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
