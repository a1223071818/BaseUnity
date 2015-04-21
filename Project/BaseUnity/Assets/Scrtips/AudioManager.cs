using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour {

	public AudioMixer masterMixter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetMasterValuem(float volume){

		if (masterMixter) {
			masterMixter.SetFloat("MasterValuemParam",volume);
		}
	}
}
