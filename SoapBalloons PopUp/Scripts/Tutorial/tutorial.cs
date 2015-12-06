using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {

	private bool inside = false;

	public GameObject tut;

	void OnTriggerEnter2D()
	{
		inside = true;
		tut.active = true;
	}
	
	void Update()
	{
		if(inside == true && Time.timeScale>=0)
		{
			Time.timeScale-=Time.deltaTime*3f;
			Click();
		}
	}
	
	void Click()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			tut.active = false;
			Time.timeScale = 1;
			inside = false;
		}
	}
	
	
}
