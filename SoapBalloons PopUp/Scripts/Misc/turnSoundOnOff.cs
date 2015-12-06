using UnityEngine;
using System.Collections;

public class turnSoundOnOff : MonoBehaviour {

	
	//private Color col;
	private GameObject camera;
	
	public bool onOff;
	
	void Awake()
	{
		camera = GameObject.FindGameObjectWithTag("MainCamera");
		GetComponent<SpriteRenderer>().color =  new Color(0f,0.55f,0.6f, 1f);
	}
	
	void OnMouseUp()
	{
		if(onOff==false)
		{
			camera.GetComponent<audioListenerOnCamera>().isPaused=true;
			onOff = true;
			GetComponent<SpriteRenderer>().color = new Color(0.6f,0.1f,0.1f, 1f);
		}
		else 
		{
			camera.GetComponent<audioListenerOnCamera>().isPaused=false;
			onOff = false;
			GetComponent<SpriteRenderer>().color = new Color(0f,0.55f,0.6f, 1f);
		}
		
	}
}
