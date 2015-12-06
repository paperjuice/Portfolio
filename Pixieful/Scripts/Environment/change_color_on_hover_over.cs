using UnityEngine;
using System.Collections;

public class change_color_on_hover_over : MonoBehaviour {


    //store start-up colour
    private Color col;

    //activate when I use it to buy stuff and I have enough money
    public bool is_working = false;

    public byte r;
    public byte g;
    public byte b;
    public byte a;

    void Start()
    {
        col = GetComponent<SpriteRenderer>().color;
    }


    void OnMouseEnter()
    {
        if(is_working == true)
            GetComponent<SpriteRenderer>().color += new Color32(r, g, b, a);
    }

    void OnMouseExit()
    {
        if (is_working == true)
            GetComponent<SpriteRenderer>().color = col;
    }

    void OnMouseUp()
    {
        if (is_working == true)
            GetComponent<SpriteRenderer>().color = col;
    }


}
