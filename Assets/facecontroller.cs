using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facecontroller : MonoBehaviour {
	public Vector3 origin;
	private Vector3 screenPoint;
	private Vector3 offset;
	public float dis;
	public bool IsDragable = true;
	public GameObject childcircle = null;
	private SpriteRenderer sr;
//	void SetTransformX(float n){
//		transform.position = new Vector3(n, transform.position.y, transform.position.z);
//	}
	void Start(){
		origin = transform.position;
//		childcircle = transform.Find ("Circle").gameObject;
		if (childcircle != null) {
			sr = childcircle.GetComponent<SpriteRenderer> ();
		}	
	}
		
	void OnMouseDown()
	{
		if(IsDragable)   // Only do if IsDraggable == true
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
		if (Input.GetMouseButtonUp (0)) {
			sr.enabled = false;
		}
	}
	void OnMouseDrag()
	{
		if(IsDragable)    // Only do if IsDraggable == true
		{	
			
			sr.enabled = true;Color tmp = sr.color;
			tmp.a = 0.5f;
			sr.color = tmp;
			Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); // hardcode the y and z for your use

			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;

			if (Vector3.Distance (origin, curPosition) < dis) {
						
				transform.position = curPosition;
	
			}
		}
	}

}
