using UnityEngine;
using System.Collections;

public class adverts : MonoBehaviour {

	private string idOfTheAds = "ca-app-pub-7935571317368153/8212912822";
	private AdMobPlugin adMobPlug;
	public bool showAd = false;
	
	
	
	
	void Start()
	{	
		showAd = true;
	
		adMobPlug = GetComponent<AdMobPlugin>();
		
		adMobPlug.CreateBanner(idOfTheAds, AdMobPlugin.AdSize.SMART_BANNER, false);
		adMobPlug.RequestAd();
	}
	
	void Update()
	{
		Adverts();
	}
	
	void Adverts()
	{
		if(showAd == true)
		{
			adMobPlug.ShowBanner();
			//Debug.Log("1");
		}
		else
		{
			adMobPlug.HideBanner();
			//Debug.Log("2");
		}	
	}
	
}
