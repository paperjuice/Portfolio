using UnityEngine;
using System.Collections;

public class move_up_text : MonoBehaviour {

    private Color a;

    void Update()
    {
        a = GetComponent<TextMesh>().color;
        a.a -= Time.deltaTime * 0.5f;
        GetComponent<TextMesh>().color = a;


        transform.position += Vector3.up * Time.deltaTime * 2f;
    }
}
