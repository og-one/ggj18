using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class changecolor : MonoBehaviour
{
    public GameObject blue;
    public GameObject blue2;
    public GameObject green;
    public GameObject green2;
    public static int randint = 0;
	private List<Color> colors = new List<Color>{
		new Color(144/255f,180/255f,197/255f,1f), new Color(236/255f,199/255f,110/255f,1f),new Color(197/255f,227/255f,223/255f,1f),new Color(255/255f,255/255f,179/255f,1f),Color.white,
		new Color(185/255f,209/255f,164/255f,1f),new Color(78/255f,140/255f,168/255f,1f),new Color(184/255f,175/255f,202/255f,1f),new Color(145/255f,173/255f,112/255f,1f), Color.black,
    };
	// Use this for initialization
	void Start () {

        blue.GetComponent<Renderer>().material.SetColor("_Color", colors[randint]);
        blue2.GetComponent<Renderer>().material.SetColor("_Color", colors[randint]);
        green.GetComponent<Renderer>().material.SetColor("_Color", colors[randint+5]);
        green2.GetComponent<Renderer>().material.SetColor("_Color", colors[randint+5]);


      }
	
	// Update is called once per frame
	void Update () {
		
	}



}

