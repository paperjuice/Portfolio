using UnityEngine;
using System.Collections;

public class saveGame : MonoBehaviour {



	void Start()
	{
		PlayerPrefs.SetInt("points", pointsGathered.points);
		
	}
}
