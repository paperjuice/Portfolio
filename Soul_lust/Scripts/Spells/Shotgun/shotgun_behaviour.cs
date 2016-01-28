using UnityEngine;
using System.Collections;

public class shotgun_behaviour : MonoBehaviour
{

    public KeyCode key_press;
    public GameObject particles;

    //cooldown local
    private float time_cd;
    public float cd;


    private bool start_charge = false;
    private bool start_cooldown = false;
    private float time;
    private float end_time = 0.3f;



    void Update()
    {
        if (time_cd <= 0)
        {
            if (Input.GetKeyDown(key_press))
            {
                Time.timeScale = 0.1f;
                start_charge = true;
                start_cooldown = true;
                particles.gameObject.SetActive(true);
            }
        }

        if (start_charge == true)
        {
            time += Time.deltaTime;

            if (time >= end_time)
            {
                GetComponent<BoxCollider>().enabled = true;
                GetComponent<MeshRenderer>().enabled = true;
                
            }

            if (time >= end_time + 0.1f)
            {
                GetComponent<BoxCollider>().enabled = false;
                GetComponent<MeshRenderer>().enabled = false;
                particles.gameObject.SetActive(false);
                time = 0f;
                start_charge = false;
                Time.timeScale = 1f;
            }
        }

        if (start_cooldown == true)
        {
            time_cd += Time.deltaTime;

            if (time_cd >=cd)
            {
                start_cooldown = false;
                time_cd = 0f;
                
            }
        }
    }

}