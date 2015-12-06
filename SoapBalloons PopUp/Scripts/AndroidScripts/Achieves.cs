using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Achieves : MonoBehaviour {

	private GameObject[] panels;
	
	void Awake()
	{
		panels = GameObject.FindGameObjectsWithTag("achieves");
	}
	
	void Start()
	{
		if(panels.Length >=2)
		{
			Destroy(gameObject);
		}
		else
		{
			Application.DontDestroyOnLoad(gameObject);
		}
	}
	
	void Update()
	{
		UnlockAchieves();
	}
	
	void UnlockAchieves()
	{
	
		//1
		if(pointsGathered.points>=2)
		{
			Social.ReportProgress("CgkIo_uyr9QTEAIQAQ", 100.0f, (bool success) => {});
		}
		
		//2
		if(pointsGathered.points>=6)
		{
			Social.ReportProgress("CgkIo_uyr9QTEAIQAg", 100.0f, (bool success) => {});
		}
		
		//3
		if(pointsGathered.points>=8)
		{
			Social.ReportProgress("CgkIo_uyr9QTEAIQAw", 100.0f, (bool success) => {});
		}
		
		//4
		if(pointsGathered.points>=11)
		{
			Social.ReportProgress("CgkIo_uyr9QTEAIQBA", 100.0f, (bool success) => {});
		}
		
		//5
		if(pointsGathered.points>=18)
		{
			Social.ReportProgress("CgkIo_uyr9QTEAIQBQ", 100.0f, (bool success) => {});
		}
		
		//6
		if(pointsGathered.points>=30)
		{
			Social.ReportProgress("CgkIo_uyr9QTEAIQBg", 100.0f, (bool success) => {});
		}
		
		//7
		if(pointsGathered.points>=38)
		{
			Social.ReportProgress("CgkIo_uyr9QTEAIQBw", 100.0f, (bool success) => {});
		}
	}
	
}
