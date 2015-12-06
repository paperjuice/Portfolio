using UnityEngine;
using System.Collections;

public class fadein_fadeout : MonoBehaviour {

    public float a;
    private int fade = 1;


    IEnumerator Start()
    {
        fade = 1;

        yield return new WaitForSeconds(1);

        fade = 2;

        yield return new WaitForSeconds(2);

        fade = 3;

        yield return new WaitForSeconds(2);

        Application.LoadLevel("Main_menu");
    }


    void Update()
    {
        if (fade == 1)
        {
            a += Time.deltaTime;
        }


        if (fade == 3)
        {
            a -= Time.deltaTime * 0.5f;
        }




        GetComponent<TextMesh>().color = new Color(1, 1, 1, a);
    }
}
