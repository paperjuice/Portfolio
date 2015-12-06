using UnityEngine;
using System.Collections;

public class onBalloons : MonoBehaviour {


	private GameObject hiddenScore;
	private GameObject hiddenScoreV2;
	
	
	void Awake()
	{
		hiddenScore = GameObject.FindGameObjectWithTag("sideGame");
		hiddenScoreV2 = GameObject.FindGameObjectWithTag("sideGameExtra");
	}	
	
	void OnMouseDown()
	{
		hiddenScore.GetComponent<hiddenScore>().colorIsFading = true;
		hiddenScoreV2.GetComponent<hiddenScoreV2>().colorIsFading = true;
		hiddenScore.GetComponent<hiddenScore>().score +=1;
		
	}

}
