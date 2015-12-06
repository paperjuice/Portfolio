using UnityEngine;
using System.Collections;

public class offAds : MonoBehaviour {

	public adverts ads;
	
	/*void Awake()
	{
		ads = GameObject.FindGameObjectWithTag("ads");	
	}*/
	
	void OnMouseDown()
	{
		ads.GetComponent<adverts>().showAd = false;
		//Debug.Log(ads.GetComponent<adverts>().showAd);
	}
}
