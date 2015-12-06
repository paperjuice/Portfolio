using UnityEngine;
using System.Collections;

public class onOffSound : MonoBehaviour {

	public static bool soundOff;
	public GameObject panel;
	
	
	void Awake()
	{
		if(soundOff == true)
		{
			panel.active = true;
		}
		else
		{
			panel.active = false;
		}
	}
	
	void OnMouseDown()
	{
		if(panel.active == false)
		{
			panel.active = true;
			soundOff = true; 
		}
		else
		{
			panel.active = false;
			soundOff = false;
		}
	}
}
