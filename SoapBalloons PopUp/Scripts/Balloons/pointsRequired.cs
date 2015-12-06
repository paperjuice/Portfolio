using UnityEngine;
using System.Collections;

public class pointsRequired : MonoBehaviour {

//this script is to verify if you have enough points in order to unlock next level



	public int pointsRequiredToUnlock;
	
	void Update()
	{
		if(pointsGathered.points >= pointsRequiredToUnlock)
		{
			GetComponent<SpriteRenderer>().color = Color.white;
			GetComponent<CircleCollider2D>().enabled = true;
		}
	}
}
