using UnityEngine;
using System.Collections;

public class next_scene : MonoBehaviour {

    private bool fade_in = false;
    private float col = 0f;

    public GameObject tab;

    void OnMouseDown()
    {
        fade_in = true;
    }

    void Update()
    {
        if (fade_in == true)
        {
            col += Time.deltaTime * 1.5f;
            tab.GetComponent<SpriteRenderer>().color = new Color(tab.GetComponent<SpriteRenderer>().color.r, tab.GetComponent<SpriteRenderer>().color.g, tab.GetComponent<SpriteRenderer>().color.b, col);
        }

        if (col >= 1)
        {
            Application.LoadLevel("Game_2");
        }
    }
}
