using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour {

public Transform[] joints;
	public int lengthOfLineRenderer;

	void Update()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        var points = new Vector3[lengthOfLineRenderer];
        var t = Time.time;
        for (int i = 0; i < lengthOfLineRenderer; i++)
        {
            points[i] = joints[i].position;
        }
        lineRenderer.SetPositions(points);
    }
}
