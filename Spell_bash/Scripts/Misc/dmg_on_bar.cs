using UnityEngine;
using System.Collections;

public class dmg_on_bar : MonoBehaviour {



    public bool activate;
    //public int activate_v2 = 0;
    public GameObject particle;

    private float time = 0f;
    private float end_time = 0.2f;

    void Update()
    {
        if (activate == true)
        {

            if (time <= 0)
            {
                Instantiate(particle, transform.position, transform.rotation);
            }


            time += Time.deltaTime;

            
            
            
            if (time >= end_time)
            {
                
                activate = false;
                time = 0f;
            }
        }
    }
}
