using UnityEngine;
using System.Collections;

public class unlock : MonoBehaviour {

    [SerializeField]
    private int points_necessary;

    void Start()
    {
        player_behaviour.high_score = PlayerPrefs.GetInt("high_score");


        if (player_behaviour.high_score >= points_necessary)
        {
            gameObject.SetActive(false);
        }
    }

}
