using UnityEngine;
using System.Collections;

public class follow_behaviour : MonoBehaviour
{

    public float ms;
    public float rs;

    private float time = 2f;
    private int random_rotation = 0;

    void FixedUpdate()
    {
        if (ms <= 15f)
        {
            ms += Time.deltaTime * 0.2f;
        }

        transform.position += ms * Vector3.forward * Time.deltaTime;
        Move();
    }


    void Move()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            random_rotation = Random.Range(0, 2);
            time = 2f;
        }

        if (random_rotation == 0)
        {
            transform.position += Vector3.right * rs * Time.deltaTime;
        }

            if (random_rotation == 1)
            {
                transform.position -= Vector3.right * rs * Time.deltaTime;
            }


            if (transform.position.x >= 3f)
            {
                random_rotation = 1;
            }

            if (transform.position.x <= -3f)
            {
                random_rotation = 0;
            }
    }

}
