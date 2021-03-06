﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCFaceDisplay : MonoBehaviour {
    public int index;
    public Text score;
    public Text rate;

    List<Vector3> positions;
    void Start () {
        //index = 0,1,2
        if (index < FaceManager.npc_list_of_positions.Count)
        {
            positions = FaceManager.npc_list_of_positions[index];
            int x = 0;
            foreach (Transform child in transform)
            {
                child.position = positions[x];
                x++;
            }
        }else{
            Debug.Log("You don't have this saved face position Data. You only have "+FaceManager.npc_list_of_positions.Count+" groups of data.");
        }

        score.text = (FaceManager.Scores[index] * 1000000f).ToString();
        if (FaceManager.Scores[index] > .5f)
            score.text = "Good!!";
        else
            score.text = "Bad!!";
    }

	// Update is called once per frame
	void Update () {
		
	}
}
