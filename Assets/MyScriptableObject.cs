using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class NewBehaviourScript : ScriptableObject {

	public List<Vector3> Eye_Right; 
	public List<Vector3> Eye_Left; 
	public List<Vector3> EyeBrow_Right_1; 
	public List<Vector3> EyeBrow_Right_2; 
	public List<Vector3> EyeBrow_Right_3;
	public List<Vector3> EyeBrow_Left_1;  
	public List<Vector3> EyeBrow_Left_2; 
	public List<Vector3> EyeBrow_Left_3;  
	public List<Vector3> Mouth_1; 
	public List<Vector3> Mouth_2; 
	public List<Vector3> Mouth_3; 
	public List<Vector3> Mouth_4; 
	public List<Vector3> Mouth_5; 
	public List<Vector3> Mouth_6; 

	public List<Vector3> eye_right{
		get{ return Eye_Right; }
	}
	public List<Vector3> eye_left{
		get{ return Eye_Left; }
	}

	public List<Vector3> eyebrow_right_1{
		get{ return EyeBrow_Right_1; }
	}

	public List<Vector3> eyebrow_right_2{
		get{ return EyeBrow_Right_2; }
	}

	public List<Vector3> eyebrow_right_3{
		get{ return EyeBrow_Right_3; }
	}

	public List<Vector3> eyebrow_left_1{
		get{ return EyeBrow_Left_1; }
	}

	public List<Vector3> eyebrow_left_2{
		get{ return EyeBrow_Left_2; }
	}

	public List<Vector3> eyebrow_left_3{
		get{ return EyeBrow_Left_3; }
	}

	public List<Vector3> mouth_1{
		get { return Mouth_1; }
	}

	public List<Vector3> mouth_2{
		get { return Mouth_2; }
	}

	public List<Vector3> mouth_3{
		get { return Mouth_3; }
	}

	public List<Vector3> mouth_4{
		get { return Mouth_4; }
	}

	public List<Vector3> mouth_5{
		get { return Mouth_5; }
	}

	public List<Vector3> mouth_6{
		get { return Mouth_6; }
	}

}
