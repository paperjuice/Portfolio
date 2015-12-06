using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class highScore : MonoBehaviour {

	private GameObject score;
	private float v;
	
	private float highestScore;
	
	
	
	
	void Awake()
	{
		score = GameObject.FindGameObjectWithTag("score");
	}
	
	void Start()
	{	
		Achievements();
		//aici stochez highscorul
	
		if(highestScore <= score.GetComponent<score>().scoreText)
		{
			highestScore = PlayerPrefs.GetFloat("score");
			
			Social.ReportScore(Mathf.FloorToInt( score.GetComponent<score>().scoreText ) , "CgkItJ_j_tcZEAIQBg", (bool success) =>{});
		}
		
		GetComponent<TextMesh>().text ="" + highestScore.ToString("N0");
	}
	
	
	
	//achivement-uri de deblocat
	void Achievements()
	{
		////achivement 1 
		if(score.GetComponent<score>().scoreText >= 10.0f)
		{
			Social.ReportProgress("CgkItJ_j_tcZEAIQAQ", 100.0f, (bool success) => {});
			//Debug.Log("1");
		}
		
		
		////achivement 2
		{
			if(score.GetComponent<score>().scoreText>=1000f)
			{
				Social.ReportProgress("CgkItJ_j_tcZEAIQAg", 100.0f, (bool success) => {});
				//Debug.Log("2");
			}
		}
		
		////achivement 3
		{
			if(score.GetComponent<score>().scoreText>=1960f)
			{
				Social.ReportProgress("CgkItJ_j_tcZEAIQAw", 100.0f, (bool success) => {});
			}
		}
		
		////achivement 4
		{
			if(score.GetComponent<score>().scoreText>=3000f)
			{
				Social.ReportProgress("CgkItJ_j_tcZEAIQBA", 100.0f, (bool success) => {});
			}
		}
		
		////achivement 5
		{
			if(score.GetComponent<score>().scoreText>=10000f)
			{
				Social.ReportProgress("CgkItJ_j_tcZEAIQBQ", 100.0f, (bool success) => {});
			}
		}
	}
	
}
