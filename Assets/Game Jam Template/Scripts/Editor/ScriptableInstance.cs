using UnityEngine;
using UnityEditor;

public class YourClassAsset
{
	[MenuItem("Assets/Create/FaceSO")]
	public static void CreateAsset ()
	{
		ScriptableObjectUtility.CreateAsset<NewBehaviourScript> ();
	}
}