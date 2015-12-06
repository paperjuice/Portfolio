using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {


    private bool start;
    private GameObject player_r;
    private GameObject player_b;

    public static int redWon;
    public static int blueWon;
    public TextMesh pointsText;
    public GameObject redWins;
    public GameObject blueWins;
    public GameObject even;


    void Awake()
    {
        player_r = GameObject.FindGameObjectWithTag("Player_1");
        player_b = GameObject.FindGameObjectWithTag("Player_2");
    }

    IEnumerator Start()
    { 
        yield return new WaitForSeconds(6f);
        start = true;
    }

    void Update()
    {
        if (start)
        {
            if (player_r.GetComponent<playerSts>().health <= 0 && player_b.GetComponent<playerSts>().health > 0)
            {
                blueWins.SetActive(true);
                blueWon++;
                enabled = false;
            }

            if (player_b != null)
            {
                if (player_b.GetComponent<playerSts>().health <= 0 && player_r.GetComponent<playerSts>().health > 0)
                {
                    redWins.SetActive(true);
                    redWon++;
                    enabled = false;
                }

            }

            if (player_r.GetComponent<playerSts>().health <= 0 && player_b.GetComponent<playerSts>().health <= 0)
            {
                even.SetActive(true);
                enabled = false;
                blueWon++;
                redWon++;
            }

            
        }

        Text();
    }

    void Text()
    {
        pointsText.text = redWon + " - " + blueWon;
    }

    
}
