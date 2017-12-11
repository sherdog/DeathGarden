using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlockd_";

	public static void SetMasterVolume(float vol)
	{
		if (vol >= 0f && vol <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, vol);
		} else {
			Debug.LogError ("Master volume out of ranage");
		}
	}

	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void SetDifficulty(float dif)
	{
		if (dif >= 0f && dif <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, dif);
		} else {
			Debug.LogError ("Difficulty out of range");
		}
	}

	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}

	public static void UnlockLevel(int level)
	{
		PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1);
	}

	public static bool IsLevelUnlocked(int level)
	{
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);

		return isLevelUnlocked;
	}

	public static int GetLevelUnlocked()
	{
		return PlayerPrefs.GetInt (LEVEL_KEY);
	}

}
