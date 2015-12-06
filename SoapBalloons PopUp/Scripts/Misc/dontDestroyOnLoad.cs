using UnityEngine;
using System.Collections;

public class dontDestroyOnLoad : MonoBehaviour {
//used for background sound
		
	public static bool isOn;

	void Awake()
	{
		DontDestroyOnLoad(gameObject);
		
	
		/*if(GetComponent<AudioSource>().isPlaying == true)
		{
			GetComponent<AudioSource>().playOnAwake = false;
		}*/
		
		if(isOn==false)
		{
			//GetComponent<AudioSource>().playOnAwake = true;
			isOn=true;
		}
		else
		{
			Destroy(gameObject);
		}
		
	}
}
