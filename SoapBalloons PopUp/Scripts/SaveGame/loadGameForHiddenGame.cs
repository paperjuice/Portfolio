using UnityEngine;
using System.Collections;

public class loadGameForHiddenGame : MonoBehaviour {

	private GameObject hiddenScore;
	
	void Awake()
	{
		hiddenScore = GameObject.FindGameObjectWithTag("sideGame");
	}
	
	void Start()
	{
		hiddenScore.GetComponent<hiddenScore>().score = PlayerPrefs.GetInt("hiddenScore");
	}
}
