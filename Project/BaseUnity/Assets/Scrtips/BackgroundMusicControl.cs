using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class BackgroundMusicControl : MonoBehaviour {

	public AudioMixerSnapshot backgroundSnapshot;
	public AudioMixerSnapshot dangerousSnapshot;

	void OnTriggerEnter(Collider other){
		Debug.Log ("Enter!!!");
		backgroundSnapshot.TransitionTo (2);
	}

	void OnTriggerExit(Collider other){
		Debug.Log ("Exit!!!");
		dangerousSnapshot.TransitionTo (2);
	}
}
