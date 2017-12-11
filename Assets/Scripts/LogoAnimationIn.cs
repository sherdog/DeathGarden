using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoAnimationIn : MonoBehaviour {

	public float fadeInTime;
	public float alphaTo;
	public int winkTimes = 0;
	private int currentWinkCount = 0;

	private Color currentColor;
	private Text textObject;
	private float startAlpha;


	private bool isEyeClosed = false;

	// Use this for initialization
	void Start () {
		
		textObject = GetComponent<Text> ();
		currentColor = textObject.color;
		startAlpha = currentColor.a;

		if (winkTimes > 0) {
			Invoke ("Wink", 1.4f);
		}
	}

	void Wink ()
	{
		if (currentWinkCount <= winkTimes) {
			
			if (isEyeClosed) {
				textObject.text = "o";
				isEyeClosed = false;
			} else {
				isEyeClosed = true;
				textObject.text = "-";
			}
			Invoke ("Wink", 0.1f);
			currentWinkCount++;
		} else {
			textObject.text = "o";
			Invoke ("ResetWink", 0f);
		}
	}

	void ResetWink()
	{
		currentWinkCount = 0;
		Invoke ("Wink", 3.0f);
	}

	// Update is called once per frame
	void Update () {

		if (Time.timeSinceLevelLoad < fadeInTime) {
			float alphaChange = Time.deltaTime / fadeInTime;
			if (startAlpha > alphaTo) {
				currentColor.a -= alphaChange;
			} else {
				currentColor.a += alphaChange;
			}
			textObject.color = currentColor;
		}
	}
}
