using UnityEngine;
using System.Collections;

public class saveGameForHiddenScore : MonoBehaviour {

	private GameObject hiddenScore;
	
	void Awake()
	{
		hiddenScore = GameObject.FindGameObjectWithTag("sideGame");
	}
	

	void Start()
	{
		PlayerPrefs.SetInt("hiddenScore",hiddenScore.GetComponent<hiddenScore>().score);
	}
}
