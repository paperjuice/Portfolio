using UnityEngine;
using System.Collections;

public class onOffSoundOnAudioSource : MonoBehaviour {

	void Start()
	{
		if(onOffSound.soundOff == true)
		{
			GetComponent<AudioSource>().mute  = true;
		}
		else
		{
			GetComponent<AudioSource>().mute  = true;
		}
	}
}
