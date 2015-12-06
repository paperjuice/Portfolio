 using UnityEngine;
using System.Collections;

public class enemy_bomb_attack_v2 : MonoBehaviour {

    //player tag
    private GameObject player;

    //enemy tag
    private GameObject[] enemies;

    //camera tag
    private GameObject camera;

    private bool explode_start;
    private float time;
    private float end_time = 1;                     //how long until explosion

    //flash effect
    private GameObject global_light;
    private bool activate_flash = false;
    private float time_flash = 0f;
    private float end_time_flash = 0.1f;


    //store hero max hp
    private float hero_max_hp;

    private bool explode_now;               //if its true it expldoes

    public GameObject enemy_body;
    public float dmg_percentage;

    void Awake()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        global_light = GameObject.FindGameObjectWithTag("global_light");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    IEnumerator Start()
    {
        hero_max_hp = player.GetComponent<hero_behaviour>().max_hp;

        while (true)
        {
            //get the tag every 0.5sec
            enemies = GameObject.FindGameObjectsWithTag("enemy");

            yield return new WaitForSeconds(0.5f);
        }
    }

    void Update()
    {
        Trigger_explosion();
        Explode_inProgress();
       // Screen_flash();
    }

    void Trigger_explosion()
    {
        if (player != null)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < 3)
            {
                enemy_body.GetComponent<enemy_behaviour>().ms = 0;
                //countdown for explosion
                explode_start = true;                                                   
            }
        }
    }

    void Explode_inProgress()
    {
        if (explode_start == true)
        {
            time += Time.deltaTime;
            {
                if (time >= end_time)
                {

                    //activate collider to see how many enemies are inside
                    GetComponent<SphereCollider>().enabled = true;

                    if (player != null)
                    {
                        if (Vector3.Distance(transform.position, player.transform.position) < 6)
                        {
                            player.GetComponent<hero_behaviour>().hp -= dmg_percentage / 100 * hero_max_hp;
                            global_light.GetComponent<flash_effect>().start_flash = true;
                            camera.GetComponent<Animator>().SetTrigger("shake");
                        }
                    }

                    foreach (GameObject enemy in enemies)
                    {
                        if (Vector3.Distance(transform.position, enemy.transform.position) < 6)
                        {
                            enemy.GetComponent<enemy_behaviour>().friendly_fire = true;
                        }
                    }

                    enemy_body.GetComponent<enemy_behaviour>().health = -1;
                    explode_start = false;
                    time = 0f;
                }
            }
        }
    }

    void Screen_flash()
    {
        if (activate_flash == true)
        {
            global_light.GetComponent<Light>().enabled = true;
            time_flash += Time.deltaTime;

            if (time_flash >= end_time_flash)
            {
                print("boom");
                global_light.GetComponent<Light>().enabled = false;
                time = 0f;
                activate_flash = false;
            }
        }
    }





}
