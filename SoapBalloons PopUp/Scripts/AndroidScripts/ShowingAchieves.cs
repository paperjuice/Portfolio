using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;


public class ShowingAchieves : MonoBehaviour {

	void OnMouseDown()
	{
		Social.ShowAchievementsUI();
	}
}
