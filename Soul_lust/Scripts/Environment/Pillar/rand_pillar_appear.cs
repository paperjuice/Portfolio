using UnityEngine;
using System.Collections;

public class rand_pillar_appear : MonoBehaviour {



    private GameObject controller_pillar_shown;

    private bool show_pillar;
    private int random;


    private float time = 0.1f;

    void Awake()
    {
        controller_pillar_shown = GameObject.FindGameObjectWithTag("controller");
    }



    void Update()
    {
        if (controller_pillar_shown != null)
        {
            if (controller_pillar_shown.GetComponent<controller>().appear_pillar == true)
            {
                random = Random.Range(1, 5);
                time -= Time.deltaTime;
                if (time <= 0f)
                {
                    controller_pillar_shown.GetComponent<controller>().appear_pillar = false;
                    time = 0.1f;
                }
            }
        }




        if (random == 1)
        {
            if (transform.position.y <= -1f)
            {
                transform.position += Vector3.up * Time.deltaTime *5f;
            }
        }
        else if (random != 1)
        {
            if (transform.position.y >= -8f)
            {
                transform.position -= Vector3.up * Time.deltaTime * 5f;
            } 
        }


    }



}
