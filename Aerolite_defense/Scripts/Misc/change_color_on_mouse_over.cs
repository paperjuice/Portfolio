using UnityEngine;
using System.Collections;

public class change_color_on_mouse_over : MonoBehaviour {

    private SpriteRenderer sprite;

    public GameObject sound;
    
    //color bytes rbga
    public byte r;
    public byte g;
    public byte b;


    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void OnMouseEnter()
    {
        sprite.color -= new Color32(r, g, b, 0);
        Instantiate(sound, transform.position, transform.rotation);
    }

    void OnMouseExit()
    {
        sprite.color += new Color32(r, g, b, 0);
    }
}
