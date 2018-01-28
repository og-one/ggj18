using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class changecolor : MonoBehaviour
{
    public GameObject blue;
    public GameObject blue2;
    public GameObject green;
    public GameObject green2;
    int randint = 1;
    public static bool change = true;
    private List<Color> colors = new List<Color>{
        Color.yellow,Color.red, Color.blue,Color.green,Color.grey,Color.white,
        Color.red,Color.black, Color.green,Color.blue,Color.blue,Color.black,
    };
	// Use this for initialization
	void Start () {
        if (change )
        {
            randint = Random.Range(0,5);
            change = false;
        }

        blue.GetComponent<Renderer>().material.SetColor("_Color", colors[randint]);
        blue2.GetComponent<Renderer>().material.SetColor("_Color", colors[randint]);
        green.GetComponent<Renderer>().material.SetColor("_Color", colors[randint+6]);
        green2.GetComponent<Renderer>().material.SetColor("_Color", colors[randint+6]);


      }
	
	// Update is called once per frame
	void Update () {
		
	}



}

