using UnityEngine;
using System.Collections;

public class onAudioSource : MonoBehaviour {

	void Update()
	{
		if(onOffSound.soundOff == true)
		{
			GetComponent<AudioSource>().mute = true;
		}
		else
		{
			GetComponent<AudioSource>().mute = false;
		}
	}
}
