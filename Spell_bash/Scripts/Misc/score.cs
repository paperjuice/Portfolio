using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

    public GameObject opposing_player;

    private bool player_is_dead;
    private static int score_;
    private TextMesh text;


    void Awake()
    {
        text = GetComponent<TextMesh>();
    }

    void Update()
    {
        if (opposing_player.GetComponent<heroStats>().health <= 0)
        {
            player_is_dead = true;
        }

        if (player_is_dead == true)
        {
            score_++;
            enabled = false;
        }

        text.text = "" + score_;
    }
}
