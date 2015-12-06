using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class SignIn : MonoBehaviour {


	static bool once = false;

	void Start()
	{
		Social.localUser.Authenticate((bool success) => {	});
		
		
		if(once == false)
		{
			 PlayGamesPlatform.Activate();
			 once = true;
		}
		
		
	}
}
