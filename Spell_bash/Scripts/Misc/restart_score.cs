using UnityEngine;
using System.Collections;

public class restart_score : MonoBehaviour {

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			score_red.score_red_ =0;
			score_blue.score_blue_ =0;
			Application.LoadLevel("Game_1");
		}

	}
}
