using UnityEngine;
using System.Collections;

public class fadeIn : MonoBehaviour {


    Color color;
    private bool fade_in = false;


    IEnumerator Start()
    {
        
        yield return new WaitForSeconds(5f);

        fade_in = true;
    }

    void Update()
    {
        if (fade_in == false)
        {
            color = GetComponent<TextMesh>().color;
            color.a += Time.deltaTime;
            GetComponent<TextMesh>().color = color;
        }

        if (fade_in == true)
        {
            color.a -= Time.deltaTime;
            GetComponent<TextMesh>().color = color;
        }
    }

}
