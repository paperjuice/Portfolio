using UnityEngine;
using System.Collections;

public class audioOnDeath : MonoBehaviour {
	
	public bool lowPitch;

	void Update()
	{
		AudioOnDeath(lowPitch);
	}

	public void AudioOnDeath(bool lowPitch)
	{
		if(lowPitch == true)
		{
			if(GetComponent<AudioSource>().pitch >= 0)
			{
				GetComponent<AudioSource>().pitch -= Time.deltaTime *0.5f;
			}
			if(GetComponent<AudioSource>().pitch <= 0)
			{
				GetComponent<AudioSource>().volume = 0;
			}
		}
	}
}
