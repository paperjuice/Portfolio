using UnityEngine;
using System.Collections;

public class random_behaviour : MonoBehaviour {


    private GameObject controller;
    
    private int r = 0;                          //will say in which direction will move based on random number;
    private float time;
    private int direction = 1;

    public bool start_moving;
    public float end_time;
    public float ms;

    void Update()
    {
        Moving();
    }

    void Moving()
    {
        if (start_moving == true)
        {
            
            r = Random.Range(1, 3);
            start_moving = false;
        }

        if (r == 1)
        {
            time += Time.deltaTime;

            if (time < end_time)
            {
                transform.position += Vector3.forward * direction * ms * Time.deltaTime;
            } 
            else if(time>end_time)
            {
                direction *= -1;
                r = 0;
                time = 0f;

            }
        }
        else if (r == 2)
        {
            time += Time.deltaTime;

            if (time < end_time)
            {
                transform.Rotate(Vector3.up * direction * ms * Time.deltaTime * 5 );
            }
            else if (time >= end_time)
            {
                r = 0;
                time = 0f;
            }
        }
        

    }




}
