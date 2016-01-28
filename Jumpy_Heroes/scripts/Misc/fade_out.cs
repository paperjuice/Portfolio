using UnityEngine;
using System.Collections;

public class fade_out : MonoBehaviour {

    public float power;
    private float time = 1f;

    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, 1) * Time.deltaTime * power;
        }
 


        if (GetComponent<SpriteRenderer>().color.a < 0)
        { 
            Application.LoadLevel("Main_menu");
        }
    }
}
