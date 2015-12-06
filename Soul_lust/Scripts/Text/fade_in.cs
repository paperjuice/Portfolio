using UnityEngine;
using System.Collections;

public class fade_in : MonoBehaviour {

    public float a;


    void Update()
    {
        

        if (a >= 0)
        {
            a -= Time.deltaTime * 0.6f;                                                //alpha value goes down
           GetComponent<TextMesh>().color = new Color(255,255,255,a);
        }
    }
}
