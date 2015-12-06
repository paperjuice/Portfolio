using UnityEngine;
using System.Collections;

public class move_pads : MonoBehaviour {


    public float ms;
    private float end_time=0.5f;

    private float time;
    private int direction = 1;

    

    void Update()
    {
        Direction();
        Move();
    }


    void Direction()
    {
        time += Time.deltaTime;

        if(time>=end_time)
        {
            if(direction == -1)
            {
                direction = 1;
            }
            else if (direction == 1)
            {
                direction = -1;
            }
            time = 0;
            //end_time = Random.value;
        }
    }


    void Move()
    {
        transform.position += Vector3.up * Time.deltaTime * ms * direction;
    }

}
