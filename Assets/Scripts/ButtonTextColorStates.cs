using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonTextColorStates : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler {

	public Color outColor = Color.black;
	public Color overColor = Color.blue;
	public Color downColor = Color.black;
	public Color disabledColor = Color.gray;

	private Text buttonText;
	private Button button;

	void Start()
	{
		button = GetComponent<Button> ();
		buttonText = button.GetComponentInChildren<Text> ();
	}

	public void OnPointerDown(PointerEventData data)
	{
		buttonText.color = downColor;
	}

	public void OnPointerUp(PointerEventData data)
	{
		//buttonText.color = outColor;
	}

	public void OnPointerEnter(PointerEventData data)
	{
		buttonText.color = overColor;
	}

	public void OnPointerExit(PointerEventData data)
	{
		buttonText.color = outColor;
	}

}
