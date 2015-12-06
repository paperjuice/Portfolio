using UnityEngine;
using System.Collections;

public class highscore : MonoBehaviour {

    private TextMesh text;
    private float high_score;

    void Awake()
    { 
        text = GetComponent<TextMesh>();

        if (PlayerPrefs.GetFloat("high_score") != null)
        {

            high_score = PlayerPrefs.GetFloat("high_score"); 
        }

    }

    void Start()
    {
        

        text.text = "HighScore: \n" + high_score.ToString("N0");
    }
}
