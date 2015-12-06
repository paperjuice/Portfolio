using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class unlockAchievements : MonoBehaviour {

	private Vector3 distance;


	
	void Start()
	{
		distance = transform.position;
	
		Achievements();
	}
	
	void Achievements()
	{
	
		////achivement 1 
		if(distance.y >= 10.0f)
		{
			Social.ReportProgress("CgkItJ_j_tcZEAIQAQ", 100.0f, (bool success) => {});
		}
		
		
		////achivement 2
		{
			if(distance.y>=1000f)
			{
				Social.ReportProgress("CgkItJ_j_tcZEAIQAg", 100.0f, (bool success) => {});
				Debug.Log("2");
			}
		}
		
		////achivement 3
		{
			if(distance.y>=1960f)
			{
				Social.ReportProgress("CgkItJ_j_tcZEAIQAw", 100.0f, (bool success) => {});
			}
		}
		
		////achivement 4
		{
			if(distance.y>=3000f)
			{
				Social.ReportProgress("CgkItJ_j_tcZEAIQBA", 100.0f, (bool success) => {});
			}
		}
		
		////achivement 5
		{
			if(distance.y>=10000f)
			{
				Social.ReportProgress("CgkItJ_j_tcZEAIQBQ", 100.0f, (bool success) => {});
			}
		}
	}
}
