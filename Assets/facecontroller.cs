using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facecontroller : MonoBehaviour {
	private Vector3 origin;
	private Vector3 screenPoint;
	private Vector3 offset;
	public float dis;
	public bool IsDragable = true;

//	void SetTransformX(float n){
//		transform.position = new Vector3(n, transform.position.y, transform.position.z);
//	}
	void Start(){
		origin = transform.position;
	}
		
	void OnMouseDown()
	{
		if(IsDragable)   // Only do if IsDraggable == true
		{
			screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

			offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		}
	}

	void OnMouseDrag()
	{
		if(IsDragable)    // Only do if IsDraggable == true
		{	

			Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); // hardcode the y and z for your use

			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;

			if (Vector3.Distance (origin, curPosition) < dis) {
						
				transform.position = curPosition;
	
			}
		}
	}

}
