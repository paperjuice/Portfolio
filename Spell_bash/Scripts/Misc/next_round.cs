using UnityEngine;
using System.Collections;

public class next_round : MonoBehaviour {


	void Update()
	{
		if (Input.GetKeyDown ("x")) 
		{
			Application.LoadLevel("Game_1");
		}
	}
}
