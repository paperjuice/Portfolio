using UnityEngine;
using System.Collections;

public class backScript : MonoBehaviour {
//when you press back or ESC you go back to previous scene

	public string levelName;
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(levelName);
		}
	}
}
