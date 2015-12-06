using UnityEngine;
using System.Collections;

public class enemy_sentry_attack : MonoBehaviour {

    private GameObject player;
    private float time;
    private bool is_on_cd;

    public GameObject projectile;
    public float end_time;



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //Face_player();
        Fire_projectile();
    }

    void Face_player()
    {
        Vector3 asd = player.transform.position - transform.position;
        asd.x = 0f;
        asd.y = 0f;
        Quaternion dfg = Quaternion.LookRotation(asd);
        transform.rotation = Quaternion.Lerp(transform.rotation, dfg, Time.deltaTime * 2f);
    }

    void Fire_projectile()
    {
        if (player != null)
        {
            if (Vector3.Distance(transform.position, player.transform.position) <= 15)
            {

                if (is_on_cd == false)
                {
                    Instantiate(projectile, transform.position, transform.rotation);
                    is_on_cd = true;
                }

                if (is_on_cd == true)
                {
                    time += Time.deltaTime;
                    if (time >= end_time)
                    {
                        is_on_cd = false;
                        time = 0f;
                    }
                }
            }

            if (Vector3.Distance(transform.position, player.transform.position) > 15)
            {
                time = 0f;
            }
        }
    }

}
