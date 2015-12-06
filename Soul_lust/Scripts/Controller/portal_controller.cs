using UnityEngine;
using System.Collections;

public class portal_controller : MonoBehaviour {


    private GameObject controller;
    private float time = 0f;
    private float end_time = 2f;
    private bool ins_enemy = false;

    //higher values unlock new enemies
    private int multiplier;

    //random pool of enemies
    private int r ;

    //enemy list
    public GameObject enemy_horn;
    public GameObject enemy_bomb;
    public GameObject enemy_sentry;

    


    void Awake()
    {
        controller = GameObject.FindGameObjectWithTag("controller");   
    }
    

    void Update()
    {
        if (controller != null)
        {
            multiplier = controller.GetComponent<controller>().multiplier;
        }

        Instantiate_enemy();
        Extract_hero_from_pool();
    }

    void Instantiate_enemy()
    {
        if (controller != null)
        {
            if (controller.GetComponent<controller>().enemies_no > 0)
            {
                time += Time.deltaTime;

                if (time >= end_time)
                {
                    r = Random.Range(0, controller.GetComponent<controller>().multiplier);
                    ins_enemy = true;
                    time = 0f;
                }

            }
        }
    }

    void Extract_hero_from_pool()
    {

        if (ins_enemy == true)
        {
         
            //1
            if (r >= 1 && r < 3)
            {
                Instantiate(enemy_horn, transform.position, transform.rotation);
                controller.GetComponent<controller>().enemies_no--;
            }

            //4
            else if (r >= 3 && r < 6)
            {
                Instantiate(enemy_bomb, transform.position, transform.rotation);
                controller.GetComponent<controller>().enemies_no--;
            }

            //6
            else if (r >= 6 && r < 11)
            {
                Instantiate(enemy_sentry, transform.position, transform.rotation);
                controller.GetComponent<controller>().enemies_no--;
            }


            r = 0;
            
            ins_enemy = false;
            
        }
    }

}
