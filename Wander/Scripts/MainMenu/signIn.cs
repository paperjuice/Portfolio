using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class signIn : MonoBehaviour {

	void Start()
	{
		PlayGamesPlatform.DebugLogEnabled = true;
		// Activate the Google Play Games platform
		PlayGamesPlatform.Activate();

	
		Social.localUser.Authenticate((bool success) =>{});
	}
}
