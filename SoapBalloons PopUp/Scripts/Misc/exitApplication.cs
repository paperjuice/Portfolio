using UnityEngine;
using System.Collections;

public class exitApplication : MonoBehaviour {

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
