using UnityEngine;
using System.Collections;

public class youWon : MonoBehaviour {

//the script is called when there are no balloons in the scene

	public GameObject panel;
	public int levelNumber;

	private GameObject[] balloons;	
	
	IEnumerator Start()
	{
		while(true)
		{
			balloons = GameObject.FindGameObjectsWithTag("balloon");
			yield return new WaitForSeconds(0.1f);
		}
	}
	
	void Update()
	{
		if(balloons.Length == 0)
		{
			if(levelNumber>=pointsGathered.points)
			{
				pointsGathered.points++;
			}
			
			panel.active = true;
			enabled = false;
		}
	}
	
	
}
