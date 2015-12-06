using UnityEngine;
using System.Collections;

public class onTriggerActivate : MonoBehaviour {

//dau disable la movementul de la bullet si dupa un timp isi da fadein si porneste singur;--note to self

	
	public GameObject panel;
	public float endTime;
	
	
	public float time = 0f;
	private bool isActive;
	
	
	void OnTriggerEnter2D ()
	{
		isActive= true;
	}
	
	
	
	void Update()
	{
		if(isActive == true)
		{
			panel.active=true;
			Time.timeScale -=Time.deltaTime*2;
			time+=Time.fixedDeltaTime;
			
			if(time>=endTime)
			{
				Time.timeScale=1f;
				isActive=true;
			}
		}
	}
}
