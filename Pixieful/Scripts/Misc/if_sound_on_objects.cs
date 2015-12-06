using UnityEngine;
using System.Collections;

public class if_sound_on_objects : MonoBehaviour {

	//add the script to objects that have audio source on them to store if they play or not any sound


    private AudioSource audio;


    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (on_off_global_sound.is_sound == 1)
        { 
            audio.mute = false ;
        }
        
        if(on_off_global_sound.is_sound == 0)
        {
            audio.mute = true;
        }
    }
}
