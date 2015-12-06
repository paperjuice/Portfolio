using UnityEngine;
using System.Collections;

public class score_blue : MonoBehaviour {

    public GameObject player_red;

    private bool player_is_dead;
    public static int score_blue_;
    private TextMesh text;


    void Awake()
    {
        text = GetComponent<TextMesh>();
    }

    void Update()
    {
        if (player_red.GetComponent<heroStats>().health <= 0)
        {
            player_is_dead = true;
        }

        if (player_is_dead == true)
        {
            score_blue_++;
            enabled = false;
        }

        text.text = "" + score_blue_;
    }
}
