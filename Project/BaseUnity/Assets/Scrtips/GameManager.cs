using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public Animator gameSetAnimator;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Escape)) {
			gameSetAnimator.SetTrigger("GameSetin");
		}
	}
}
