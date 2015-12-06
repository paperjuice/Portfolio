using UnityEngine;
using System.Collections;

public class exitGame : MonoBehaviour {

	
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
