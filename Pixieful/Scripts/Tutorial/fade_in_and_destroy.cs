using UnityEngine;
using System.Collections;

public class fade_in_and_destroy : MonoBehaviour {

    private bool fade_in;

    //1 for white 0 for black
    public float black_or_white;
    public float a = 1f;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);

        fade_in = true;
    }


    void Update()
    { 
        if(fade_in == true)
        {
            a -= Time.deltaTime;
            GetComponent<TextMesh>().color = new Color(black_or_white, black_or_white, black_or_white, a);

        }

        if(a<=0)
        {
            Destroy(gameObject);
        }
    }
}
