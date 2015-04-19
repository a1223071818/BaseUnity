using UnityEngine;
using System.Collections;

public class PlayGamesetSound : MonoBehaviour {


	public void PlaySound(){
		GetComponent<AudioSource> ().Play ();
	}
}
