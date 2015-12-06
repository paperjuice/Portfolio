using UnityEngine;
using System.Collections;

public class main_menu_navigation : MonoBehaviour {


    public GameObject death_particle;
    public GameObject death_sound;


    private bool load_level;

    private Vector3 target;
    private GameObject player;
    private float time;
    private float end_time=1f;

    public string level_name;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Load_level();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            load_level = true;
            Instantiate(death_particle, player.transform.position, transform.rotation);
            Instantiate(death_sound, player.transform.position, transform.rotation);
            Destroy(player.gameObject);

        }
    }

    void Load_level()
    {
        if (load_level == true)
        {
            time += Time.deltaTime;

            if (time >= end_time)
            {
                Application.LoadLevel(level_name);
            }
        }
    }


}
