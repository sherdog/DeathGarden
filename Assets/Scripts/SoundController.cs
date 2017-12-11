using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundController : MonoBehaviour {
	public AudioClip[] levelMusicArray;
	private AudioSource audioSource;

	public static SoundController instance = null;
	public AudioSource musicSource;
	public AudioSource efxSource;

	void Awake()
	{
		if (instance == null) {
			instance = this;
		} else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	}

	public void PlaySingle(AudioClip clip)
	{
		efxSource.clip = clip;
		efxSource.Play ();
	}

	public void PlayMusic (AudioClip clip)
	{
		musicSource.clip = clip;
		musicSource.Play ();
	}
}
