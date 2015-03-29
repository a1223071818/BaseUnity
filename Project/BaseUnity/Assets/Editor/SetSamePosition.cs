using UnityEngine;
using UnityEditor;
using System.Collections;

public class SetSamePosition :ScriptableWizard {

	public GameObject targetObject;
	public GameObject movebleObject;

	[MenuItem("MyTools/SetSamePosition")]
	static void CreateWizard()
	{
		ScriptableWizard.DisplayWizard ("Set Same Position", typeof(SetSamePosition), "StartSet");
	}

	void OnWizardCreate()
	{
		Vector3 position = targetObject.GetComponent<Transform> ().position;
		movebleObject.GetComponent<Transform> ().position = position;
	}

}
