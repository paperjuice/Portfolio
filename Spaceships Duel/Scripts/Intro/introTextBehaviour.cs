using UnityEngine;
using System.Collections;

public class introTextBehaviour : MonoBehaviour {

    private Color col;


    void Update()
    {
        col = GetComponent<TextMesh>().color;

        col.a -= Time.deltaTime * 0.4f;

        GetComponent<TextMesh>().color = col;

    }
}
