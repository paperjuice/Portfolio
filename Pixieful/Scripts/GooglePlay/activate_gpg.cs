using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class activate_gpg : MonoBehaviour {

    void Awake()
    {
        
    }

    void Start()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();


        Social.localUser.Authenticate((bool success) => { });
    }


}
