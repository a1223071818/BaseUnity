using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ParentAndChildren : MonoBehaviour {
	public Transform parentTransform;
	// Use this for initialization
	void Start () {
		//parentTransform.DetachChildren ();

 		int childCount = parentTransform.childCount;
//
		List<Transform> children = new List<Transform> ();

		for (int i = 0; i<parentTransform.childCount; i++) {
			children.Add(parentTransform.GetChild(i));
		}

		foreach (Transform child in children) {
			child.parent =null;
		}

//		for (int i =0; i<childCount; i++) {
//				children[i].parent = null;
//		}

//		for (int i =0; i<childCount; i++) {
//			parentTransform.GetChild(0).parent = null;
//		}

	}

	void Update(){
		if (parentTransform) {
			if(parentTransform.childCount>0) {
				parentTransform.GetChild (0).parent = null;
			}
		}
	}
}
