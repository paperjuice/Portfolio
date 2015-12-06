using UnityEngine;
using System.Collections;

public class countdown_score_start : MonoBehaviour {

    private float time = 0f;
    private float end_time = 3f;
    private GameObject player;
    private GameObject score;
    private GameObject[] walls;
    private float countdown_no = 3f;




    void Awake()
    {
        walls = GameObject.FindGameObjectsWithTag("wall");
        
        score = GameObject.FindGameObjectWithTag("score");
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        time += Time.deltaTime;

        countdown_no -= Time.deltaTime;
        score.GetComponent<TextMesh>().text = "" + countdown_no.ToString("N1");

        if (time >= end_time)
        {
            if (player != null)
            {
                player.GetComponent<position_on_area>().enabled = true;
                player.GetComponent<player_behaviour>().enabled = true;
            }

            foreach (GameObject wall in walls)
            {
                if (wall.GetComponent<rotate_behaviour>() != null)
                {
                    wall.GetComponent<rotate_behaviour>().enabled = true;
                }
            }


            

            enabled = false;
        }
    }
}
