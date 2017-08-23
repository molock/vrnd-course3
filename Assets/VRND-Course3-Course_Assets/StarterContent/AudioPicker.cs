using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPicker : MonoBehaviour {

	public AudioClip[] soundfiles;
	public AudioSource soundSource;

	// Use this for initialization
	void Start () {
		int index = Random.Range(0, soundfiles.Length);
		soundSource.clip = soundfiles[index];
		soundSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
