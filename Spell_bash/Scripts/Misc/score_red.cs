using UnityEngine;
using System.Collections;

public class score_red : MonoBehaviour {

    public GameObject player_blue;

    private bool player_is_dead;
    public static int score_red_;
    private TextMesh text;


    void Awake()
    {
        text = GetComponent<TextMesh>();
    }

    void Update()
    {
        if (player_blue.GetComponent<heroStats>().health <= 0)
        {
            player_is_dead = true;
        }

        if (player_is_dead == true)
        {
            score_red_++;
            enabled = false;
        }

        text.text = "" + score_red_;
    }
}
