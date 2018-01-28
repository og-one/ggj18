using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savedposition : MonoBehaviour {
    public int index;
    List<Vector3> positions;
//    GameObject[] components;
	// Use this for initialization
	void Start () {
        //index = 0,1,2
        if (index <= playerpositions.list_of_positions.Count)
        {
            positions = playerpositions.list_of_positions[index];
            int x = 0;
            foreach (Transform child in transform)
            {
                child.position = positions[x];
                x++;
            }
        }else{
            Debug.Log("You don't have this saved face position Data. You only have "+playerpositions.list_of_positions.Count+" groups of data.");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
