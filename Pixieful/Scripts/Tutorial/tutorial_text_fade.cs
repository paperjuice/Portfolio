using UnityEngine;
using System.Collections;

public class tutorial_text_fade : MonoBehaviour {


    private Color a;
    private int fade = 1;

    public float time;


    IEnumerator Start()
    {
        fade = 1;

        yield return new WaitForSeconds(1);

        fade = 2;

        yield return new WaitForSeconds(time);

        fade = 3;

    }


    void Update()
    {
        if (fade == 1)
        {
           // a += Time.deltaTime;

            a = GetComponent<TextMesh>().color;
            a.a += Time.deltaTime ;
            GetComponent<TextMesh>().color = a;
        }


        if (fade == 3)
        {
           // a -= Time.deltaTime * 0.5f;

            a = GetComponent<TextMesh>().color;
            a.a -= Time.deltaTime * 0.5f;
            GetComponent<TextMesh>().color = a;
        }

       

        //GetComponent<TextMesh>().color = new Color(, 1, 1, a);
    }


}
