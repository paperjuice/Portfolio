using UnityEngine;
using System.Collections;

public class audioListenerOnCamera : MonoBehaviour {

	public bool isPaused;

	void Update()
	{
		if(isPaused == false)
		{
			AudioListener.pause = false;
		}
		
		if(isPaused == true)
		{
			AudioListener.pause = true;
		}
		
	}
}
