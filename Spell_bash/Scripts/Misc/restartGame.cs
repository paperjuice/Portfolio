using UnityEngine;
using System.Collections;

public class restartGame : MonoBehaviour {

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			Application.LoadLevel("Game_1");
			Time.timeScale =1;
		}
	}
}
