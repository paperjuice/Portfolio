using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

    private GameObject[] portals;
    private float time = 0f;
    private GameObject camera_tag;


    //random enemy
    private float r_enemy = -1;

    //enemy list
    public GameObject enemy_horns;
    public GameObject enemy_bomb;
    public GameObject enemy_sentry;

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
        // Instantiate_enemies();
       // Instantiate_enemies_v2();
        Wave_Progress();
        Wave_Progress_Bar();                    //how the progress bar scales based on progress
        Boss_appearance();
    }

    void Instantiate_enemies()
    {
        foreach (GameObject portal in portals)
        {
            if (enemies_no > 0)
            {
                time += Time.deltaTime;

                if (time >= end_time)
                {
                    
                    r_enemy = Random.Range(0, multiplier);
                    print(r_enemy);
                    //1
                    if (r_enemy > 0 || r_enemy <= 1)
                    {
                        Instantiate(enemy_horns, portal.transform.position, Quaternion.identity);
                        r_enemy = 0;
                    }

                    //4
                    if (r_enemy >= 2 || r_enemy <= 6)
                    {
                        Instantiate(enemy_bomb, portal.transform.position, Quaternion.identity);
                        r_enemy = 0;
                    }
                    //6
                    if (r_enemy >= 5 || r_enemy <= 11)
                    {
                        Instantiate(enemy_sentry, portal.transform.position, Quaternion.identity);
                        r_enemy = 0;
                    }

                  //  Instantiate(enemy_horns, portal.transform.position, Quaternion.identity);
                    time = 0f;
                    enemies_no--;
                    
                }
            }
        }
    }

    void Instantiate_enemies_v2()
    {
        bool ins_enemy = false;

        if (enemies_no > 0f)
        {
            time += Time.deltaTime;

            if (time >= end_time)
            {
                ins_enemy = true;
                r_enemy= Random.Range(0, multiplier);
                time = 0f;
                enemies_no--;
            }
        }


        foreach(GameObject portal in portals)
        {
            if (ins_enemy == true)
            {
                // add the number that is above if statement to the last condition in if

                //1
                if (r_enemy >= 0 && r_enemy <= 1)
                {
                    Instantiate(enemy_horns, portal.transform.position, transform.rotation);
                    r_enemy = -1;
                }

                //4
                if (r_enemy >= 2 && r_enemy <= 5)
                {
                    Instantiate(enemy_bomb, portal.transform.position, transform.rotation);
                    r_enemy = -1;
                }

                //6
                if (r_enemy >= 6 && r_enemy <= 11)
                {
                    Instantiate(enemy_bomb, portal.transform.position, transform.rotation);
                    r_enemy = -1;
                }
            }
        }
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
            foreach(GameObject portal in portals )
            {
                portal.SetActive(false);
                print("a venit boss");
                camera_tag.GetComponent<camera_follow>().camera_boss_mode = true;
            }
        }
    }

   

}
