using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeIn : MonoBehaviour {

	public float fadeInTime;
	public float alphaTo;

	private Color currentColor;
	private Text textObject;
	private float startAlpha;

	// Use this for initialization
	void Start () {
		textObject = GetComponent<Text> ();
		currentColor = textObject.color;
		startAlpha = currentColor.a;
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
