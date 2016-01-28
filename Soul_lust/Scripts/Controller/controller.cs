using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

    private GameObject[] portals;
    private GameObject[] enemies;
    private float time = 0f;
    private GameObject camera_tag;


    //random enemy
    private float r_enemy = -1;


    //enemy list
    public GameObject enemy_horns;
    public GameObject enemy_bomb;
    public GameObject enemy_sentry;

    //pillar 
    public bool appear_pillar = false;

    //every 10 waves you go multiplier +2 which is the new chance to get a new enemy
    public int multiplier = 1;

    public GameObject progress_bar;

    public GameObject wave_text;        //text of what wave is currently on/progression
   
    public float end_time;              //time between each ins
    public int enemies_no;              //number of ins enemies

    public int wave = 1;                    //wave level 

    public int current_progress;        //progress till next wave
    public int max_progress;            //progress you need to achieve to get to next wave

    


    void Awake()
    {
        camera_tag = GameObject.FindGameObjectWithTag("MainCamera");
        portals = GameObject.FindGameObjectsWithTag("portal");
    }

    void Update()
    {
        Wave_Progress();
        Wave_Progress_Bar();                    //how the progress bar scales based on progress
        Boss_appearance();
    }


    void Wave_Progress()
    {
        if (current_progress >= max_progress)
        {
            enemies_no += 2;                        //add 2 enemies
            max_progress += 10;                     //how much we augment progress
            wave++;

            
           wave_text.GetComponent<fade_in>().a = 1;
           wave_text.GetComponent<TextMesh>().text = "Wave " + wave;

           current_progress = 0;


            //pillar appear 
           appear_pillar = true;



        }
    }

    void Wave_Progress_Bar()
    {
        float a = current_progress;                                     //set a variable because its retarded
        float b = max_progress;                                         //muie

        progress_bar.transform.localScale = new Vector3(a/b,1f,1f);
    }


    //when wave % 10 == 0 boss appear
    void Boss_appearance()
    {
        if (wave % 10 == 0)
        {
            print("boss appear");

            foreach (GameObject portal in portals)
            {
                portal.GetComponent<portal_controller>().enabled = false;
            }


            //get all the enemies and destroy them
            enemies = GameObject.FindGameObjectsWithTag("enemy");
            foreach (GameObject enemy in enemies)
            {
                Destroy(enemy.gameObject);
            }

            camera_tag.GetComponent<camera_follow>().camera_boss_mode = true;
        }

        else if (wave % 10 != 0)
        {
            foreach (GameObject portal in portals)
            {
                portal.GetComponent<portal_controller>().enabled = true;
            }
            camera_tag.GetComponent<camera_follow>().camera_boss_mode = false;
        }
    }

   

}
