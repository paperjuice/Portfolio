using UnityEngine;
using System.Collections;

public class high_score : MonoBehaviour {

    public static int high_score_;

    private TextMesh text;



    void Awake()
    {
        text = GetComponent<TextMesh>();
    }


    void Start()
    {
        high_score_ = PlayerPrefs.GetInt("high_score");
    }


    void Update()
    {
        text.text = "Best Score:\n" + high_score_.ToString("N0");

        if (score.score_ >= high_score_)
        {
            high_score_ = score.score_;
            PlayerPrefs.SetInt("high_score", high_score_);
        }
    }
}
