using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facecontroller : MonoBehaviour {

	private Renderer rend; 
	private SpriteRenderer sr;

	private Vector3 origin;
	private Vector3 screenPoint;
	private Vector3 offset;
	public float dis;
	public bool IsDragable = true;
	public GameObject childcircle = null;
	private bool disappear=false;



	void Start(){
		origin = transform.position;
		if (childcircle != null) {
			sr = childcircle.GetComponent<SpriteRenderer> ();
		}	
		rend = GetComponent<Renderer> (); 

		Color curColor = rend.material.color;
		curColor.a = 0f;
		rend.material.color = curColor;
		// dis  = 1;
	}


	void OnMouseOver(){
		Color curColor = rend.material.color;
		curColor.a = Mathf.Lerp(curColor.a,1f,0.7f*Time.deltaTime);
		rend.material.color = curColor;
	}

	void OnMouseExit(){
		disappear = true;
	}

	void OnMouseDown()
	{
		if(IsDragable)   
		{
			sr.enabled = true;
			Color tmp = sr.color;
			tmp.a = 0.5f;
			sr.color = tmp;
			screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
			offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		}
	}
	void Update(){

		if (disappear) {
		
			Color curColor = rend.material.color;
			curColor.a =Mathf.Lerp(curColor.a,0f,0.7f*Time.deltaTime);
			rend.material.color = curColor;
			if (curColor.a <0.01f) {
				curColor.a = 0f;
				disappear = false;
			}
		}
		if (Input.GetMouseButtonUp (0)) {
			sr.enabled = false;
		}
	}

	void OnMouseDrag()
	{
		if(IsDragable)    
		{	
			sr.enabled = true;
			Color tmp = sr.color;
			tmp.a = 0.5f;
			sr.color = tmp;
			Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); 
			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;



			if (Vector3.Distance(origin, curPosition) > dis) {
				Vector3 diff = curPosition - origin;
				diff = diff.normalized * dis;
				transform.position = origin + diff;
			} else {
				transform.position = curPosition;
			}
		}
	}

}
