//HealthText.cs by Azuline Studios© All Rights Reserved
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthText : MonoBehaviour {
	//draw health amount on screen
	[HideInInspector]
	public float healthGui;
	private float oldHealthGui = -512;
    public Slider HealthSlider;
    public Image FillImage;
	[Tooltip("Color of GUIText.")]
	public Color textColor;
	[Tooltip("True if negative HP should be shown, otherwise, clamp at zero.")]
	public bool showNegativeHP = true;
	private Text guiTextComponent;
	
	void Start(){
        guiTextComponent = GetComponent<Text>();
        //guiTextComponent.color = textColor;
        guiTextComponent.enabled=false;
		oldHealthGui = -512;
        FillImage.color = textColor;
	}
	
	void Update (){
		//only update GUIText if value to be displayed has changed
		if(healthGui != oldHealthGui){
			if(healthGui < 0.0f && !showNegativeHP){
			//	guiTextComponent.text = "Health : 0";
			}else{
                HealthSlider.value = healthGui;
				//guiTextComponent.text = "Health : "+ healthGui.ToString();
			}
			oldHealthGui = healthGui;
		}
	}
	
}