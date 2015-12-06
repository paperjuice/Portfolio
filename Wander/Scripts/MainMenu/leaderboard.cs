using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class leaderboard : MonoBehaviour {

	

	void OnMouseDown()
	{
		Social.ShowLeaderboardUI();
	}
}
