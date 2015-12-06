using UnityEngine;
using System.Collections;

public class loadGame : MonoBehaviour {

	void Start()
	{
		if(PlayerPrefs.GetInt("points") != 0)
		{
			pointsGathered.points = PlayerPrefs.GetInt("points");
		}		
	}	
}
