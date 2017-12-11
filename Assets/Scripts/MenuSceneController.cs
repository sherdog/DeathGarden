using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSceneController : MonoBehaviour {
	public AudioClip backgroundSoundClip;
	// Use this for initialization
	void Start () {
		if (backgroundSoundClip) {
			SoundController.instance.PlayMusic (backgroundSoundClip);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
