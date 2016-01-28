using UnityEngine;
using System.Collections;

public class exit_application : MonoBehaviour {

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
