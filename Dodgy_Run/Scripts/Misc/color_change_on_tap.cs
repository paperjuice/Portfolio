using UnityEngine;
using System.Collections;

public class color_change_on_tap : MonoBehaviour {

    private SpriteRenderer sprite;
    private Color col;

    public byte r;
    public byte g;
    public byte b;


    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        col = sprite.color;
    }

    void OnMouseDown()
    {
        sprite.color = new Color32(r, g, b, 255);
    }
    void OnMouseUp()
    {
        sprite.color = col;
    }

}
