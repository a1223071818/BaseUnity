using UnityEngine;
using System.Collections;

public class PhysicsTest : MonoBehaviour {

	private LayerMask rayCastMask;
	// Use this for initialization
	void Start () {
		rayCastMask = LayerMask.GetMask ("MyLayer");
	}
	public Transform cubeTransform;
	// Update is called once per frame
	void Update () {
		//Physics.Raycast(
		RaycastHit hit;
		if (Physics.Raycast (cubeTransform.position, Vector3.up, out hit,1000,rayCastMask)) {
			Debug.Log("Current Name:  "+hit.collider.name);
			Debug.DrawRay(cubeTransform.position, Vector3.up*1000,Color.red);
		}
	
	}

	void FixedUpdate() {
		if (Input.GetMouseButtonDown (0)) {
			rigidbody.AddForce (Vector3.up*1000);
		}
	}


}
