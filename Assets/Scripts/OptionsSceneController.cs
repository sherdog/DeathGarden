using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsSceneController : MonoBehaviour {

	public Slider volumeSlider;
	public SceneController levelController;
	private SoundController soundController;
	public Slider difficultySlider;

	// Use this for initialization
	void Start () {
		soundController = GameObject.FindObjectOfType<SoundController> ();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}

	public void SaveAndExit()
	{
		Debug.Log ("Vol slider val " + volumeSlider.value);
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);

		levelController.Load ("MenuScene");
	}

	void Update()
	{
		if(soundController)
			soundController.musicSource.volume = volumeSlider.value;
	}

	public void SetDefaults()
	{
		volumeSlider.value = 0.8f;
		difficultySlider.value = 2f;
	}
}
