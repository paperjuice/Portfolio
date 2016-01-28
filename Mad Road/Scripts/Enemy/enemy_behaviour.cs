using UnityEngine;
using System.Collections;

public class enemy_behaviour : MonoBehaviour {

    private GameObject player;
    private GameObject camera_;
    private GameObject ins_obs;
    private float time = 1f;
    private float direction = 1f;
    private float cd = 0f;
    private float ms;

    private float time_bomb = 1f;

    public GameObject death_part;
    public GameObject bomb;
    


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camera_ = GameObject.FindGameObjectWithTag("MainCamera");
        ins_obs = GameObject.FindGameObjectWithTag("ins_obstacle");
    }


    void FixedUpdate()
    {
        Movement();
        Rotate_v3();
        Ins_bomb();
    }

    void Movement()
    {
        if (player != null)
        {
            if (transform.position.z >= player.transform.position.z)
            {
                ms = player.GetComponent<player_behaviour>().ms - 2f;
            }

            else if (transform.position.z < player.transform.position.z - 2)
            {
                ms = player.GetComponent<player_behaviour>().ms + 2f;
            }
        }
        


        transform.position += transform.forward *ms * Time.deltaTime;
    }

    void Rotate_v3()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
        Quaternion rotation_dir = Quaternion.AngleAxis((10f * direction), Vector3.up);

        time -= Time.deltaTime;

        if (time <= 0)
        {
            direction *= -1;
            time = 2.5f;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, rotation_dir, 2 * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == player)
        {
            Instantiate(death_part, transform.position, death_part.transform.rotation);
            camera_.GetComponent<Animator>().SetTrigger("shake");
            ins_obs.GetComponent<ins_obstacles>().enemy_no = 1;
            ins_obs.GetComponent<ins_obstacles>().in_combat = false;
            Destroy(gameObject);
        }
    }

    void Ins_bomb()
    {
        time_bomb -= Time.deltaTime;

        if (time_bomb <= 0)
        {
            Instantiate(bomb, bomb.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2f), transform.rotation);
            time_bomb = 0.8f;
        }
    }
}   
