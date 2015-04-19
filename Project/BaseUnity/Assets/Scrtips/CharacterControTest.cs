using UnityEngine;
using System.Collections;

public class CharacterControTest : MonoBehaviour {

	private CharacterController CC;
	// Use this for initialization
	void Start () {
		CC = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (CC.isGrounded);

		CC.Move (new Vector3 (1, 0, 0) * Time.deltaTime);
	
	}
}
