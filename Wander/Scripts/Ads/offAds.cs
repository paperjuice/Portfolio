using UnityEngine;
using System.Collections;

public class offAds : MonoBehaviour {

	private GameObject ads;
	
	void Awake()
	{
		ads = GameObject.FindGameObjectWithTag("ads");	
	}
	
	void OnMouseDown()
	{
		ads.GetComponent<ads>().showAd = false;
	}
}
