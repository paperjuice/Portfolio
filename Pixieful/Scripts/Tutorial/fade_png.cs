using UnityEngine;
using System.Collections;

public class fade_png : MonoBehaviour {

    private Color a;

    void Update()
    {
        a = GetComponent<SpriteRenderer>().color;
        a.a += Time.deltaTime *0.5f;
        GetComponent<SpriteRenderer>().color = a;
    }
}
