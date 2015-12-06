using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

    private GameObject player;


    // static score
    public static int staticScore;

    public GameObject tabStaticScore;
    public TextMesh staticText;

    public TextMesh text;
    public int max_roll = 2;
    public int score;
    public float ms;
    public int pointsValue_increase;
    public float timeUntilNextRoll;


    void Awake()
    {
        //get the player tag
        player = GameObject.FindGameObjectWithTag("Player");
    }

    IEnumerator Start()
    {
        //check the score if 0, save
        if (PlayerPrefs.GetInt("highScore") != 0)
        {
            staticScore = PlayerPrefs.GetInt("highScore");
        }



        while (true)
        {
            max_roll++;

            yield return new WaitForSeconds(timeUntilNextRoll);
        }
    }

    void Update()
    {
        MovementSpeed_Scale();
        Show_Text();
        Static_Score();
    }

    void MovementSpeed_Scale()
    {
        if (ms <= 20)
        {
            ms += Time.deltaTime * 0.03f; //ms increase by time
        }
    }

   
    void Show_Text()
    {
        text.text = "Score: " + "\n"+score.ToString("N0");
    }


    void Static_Score()
    {

        if (staticScore < score)
        {
            staticScore = score;
            PlayerPrefs.SetInt("highScore", controller.staticScore);
        }

        staticText.text = "Highest Score: \n" + staticScore.ToString("N0");

        if (player.GetComponent<playerBehaviour>().lives <= 0)
        {
            //Debug.Log("hgfgdf");
            if (tabStaticScore != null)
            {
                tabStaticScore.gameObject.SetActive(true);
            }
        }
    }
}
