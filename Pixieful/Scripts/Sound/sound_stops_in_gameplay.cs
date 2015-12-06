using UnityEngine;
using System.Collections;

public class sound_stops_in_gameplay : MonoBehaviour {

    private GameObject sound_stop;


    IEnumerator Start()
    {
        while (true)
        {
            sound_stop = GameObject.FindGameObjectWithTag("sound_stop");
            yield return new WaitForSeconds(0.5f);
        }
    }

    void Update()
    {
        if (sound_stop != null)
        {
            GetComponent<AudioSource>().volume = 0;
        }
        else if (sound_stop == null)
        {
            GetComponent<AudioSource>().volume = 0.4f;
        }
    }
}
