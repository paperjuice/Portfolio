using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;


public class showing_leaderboard : MonoBehaviour {

    void OnMouseDown()
    {
        Social.ShowLeaderboardUI();
    }
}
