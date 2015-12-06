using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;

public class player_behaviour : MonoBehaviour {

    private GameObject[] walls;
    private GameObject restart;
    private GameObject score_private;
    private GameObject high_score_tag;
    private GameObject camera_main;

    public static float high_score;

    //the more you play the faster score goes up
    float multi_score;

    //score value
    private float score_;

    public GameObject death_particles;
    public GameObject death_sound;
    public bool stop_score = false;


    void Awake()
    {
        walls = GameObject.FindGameObjectsWithTag("wall");
        restart = GameObject.FindGameObjectWithTag("restart");
        score_private = GameObject.FindGameObjectWithTag("score");
        high_score_tag = GameObject.FindGameObjectWithTag("highscore");
        camera_main = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Start()
    {
        high_score = PlayerPrefs.GetFloat("high_score");
    }


    void Update()
    {
        Score_();
        High_score();
    }

    void OnTriggerEnter2D(Collider2D col)
    { 
        foreach(GameObject wall in walls)
        {

            //when i die
            if (col.gameObject == wall)
            {
                camera_main.GetComponent<Animator>().SetTrigger("shake");
                stop_score = true;
                restart.transform.position = new Vector3(0,3.88f,0);
                Destroy(gameObject);
                Instantiate(death_particles, transform.position, Quaternion.identity);
                Instantiate(death_sound, transform.position, Quaternion.identity);

                //function triggers when you die
                Save_high_score();

                //add the money
                money.money_amount += score_;
                
                //save the money
                PlayerPrefs.SetFloat("money", money.money_amount);


                if(score_ > high_score)
                {
                    high_score = score_;
                }

                Social.ReportScore((long)Mathf.Round(high_score), "CgkIsaTVqMQIEAIQBg", (bool success) =>
                {

                    // handle success or failure
                });
            }
            
        }
    }

    void Score_()
    {
        multi_score+= 0.02f + Time.deltaTime;

        if (stop_score == false)
        {
            score_ += Time.deltaTime * multi_score;
        }

        score_private.GetComponent<TextMesh>().text = "Score:\n" + Mathf.Round(score_).ToString("N0");
        high_score_tag.GetComponent<TextMesh>().text = "HighScore:\n" + Mathf.Round(high_score).ToString("N0");
    }

    void High_score()
    {
        if (score_ > high_score)
        {
            high_score = score_;
           
        }
    }

    void Save_high_score()
    {
        PlayerPrefs.SetFloat("high_score", high_score);
    }
}
