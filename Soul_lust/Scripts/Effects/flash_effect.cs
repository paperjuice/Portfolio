using UnityEngine;
using System.Collections;

public class flash_effect : MonoBehaviour {


    private float time = 0f;
    private float end_time = 0.08f;

    public bool start_flash = false;


    void Update()
    {
        if (start_flash == true)
        {
            GetComponent<Light>().enabled = true;
            time += Time.deltaTime;

            if (time >= end_time)
            {
                GetComponent<Light>().enabled = false;
                time = 0f;
                start_flash = false;
            }
        }
    }
}
