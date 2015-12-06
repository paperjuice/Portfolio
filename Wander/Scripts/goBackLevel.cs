using UnityEngine;
using System.Collections;

public class goBackLevel : MonoBehaviour {

	public string level;

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(level);
		}
	}
}
