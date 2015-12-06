using UnityEngine;
using System.Collections;

public class pauseGame : MonoBehaviour {

	private bool isPaused = false;
	public GameObject panel;


	void OnMouseDown()
	{
		if(isPaused == false)
		{
			Time.timeScale = 0;
			isPaused = true;
			panel.active = true;
		}
		else
		{
			Time.timeScale = 1;
			isPaused = false;
			panel.active = false;
		}
	}
}
