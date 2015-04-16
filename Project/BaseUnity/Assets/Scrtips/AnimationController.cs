using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

	private Animator cubeAnimator;
	// Use this for initialization
	void Start () {
		cubeAnimator = GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {
		if (cubeAnimator) {
			if(Input.GetKeyDown(KeyCode.T)){
				cubeAnimator.SetTrigger("CubeTranslate");
			}
			if(Input.GetKeyDown(KeyCode.R)){
				cubeAnimator.SetTrigger("CubeRotate");
			}

		}
	}
}
