using UnityEngine;
using System.Collections;

public class on_off_global_sound : MonoBehaviour {

	public static int is_sound = 1;
    public GameObject x;

    void OnMouseDown()
    {
        if (is_sound == 1)
        {
            is_sound = 0;
           // x.gameObject.SetActive(true);
            //print(is_sound);
        }
        else if(is_sound == 0)
        {
            is_sound = 1;
           // x.gameObject.SetActive(false);
           // print(is_sound);
        }
        
    }

    void Update()
    {
        if (is_sound == 0)
        {
            x.gameObject.SetActive(true);
            //print(is_sound);
        }
        else if (is_sound == 1)
        {
            x.gameObject.SetActive(false);
            // print(is_sound);
        }
    }
}
