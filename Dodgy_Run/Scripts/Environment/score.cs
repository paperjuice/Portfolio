using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

    public static int score_;
    private TextMesh text;



    void Awake()
    {
        text = GetComponent<TextMesh>();
    }


    void Update()
    {
        text.text = "" + score_.ToString("N0");
    }
}
