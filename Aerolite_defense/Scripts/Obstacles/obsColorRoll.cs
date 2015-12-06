using UnityEngine;
using System.Collections;

public class obsColorRoll : MonoBehaviour {

    private SpriteRenderer sprite;
    private GameObject controller;

    public int colorCode;
    public int r;
    public int maxRoll;



    void Awake()
    {
        controller = GameObject.FindGameObjectWithTag("controller");

        sprite = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        if(controller != null)
        {
            maxRoll = controller.GetComponent<controller>().max_roll;
        }
        r = Random.Range(1, maxRoll);
    }

    void Update()
    {
        RandomColor();
    }

    void RandomColor()
    {
        if (r == 1)
        {
            sprite.color = new Color32(203, 40, 40, 255);
            colorCode = 1;
        }

        if (r == 2)
        {
            sprite.color = new Color32(218, 139, 0, 255);
            colorCode = 2;
        }

        if (r == 3)
        {
            sprite.color = new Color32(98, 184, 0, 255);
            colorCode = 3;
        }

        if (r == 4)
        {
            sprite.color = new Color32(16, 212, 147, 255);
            colorCode = 4;
        }

        if (r == 5)
        {
            sprite.color = new Color32(35, 107, 225, 255);
            colorCode = 5;
        }

        if (r == 6)
        {
            sprite.color = new Color32(102, 17, 227, 255);
            colorCode = 6;
        }

        if (r == 7)
        {
            sprite.color = new Color32(197, 19, 148, 255);
            colorCode = 7;
        }

        if (r == 8)
        {
            sprite.color = new Color32(233, 233, 233, 255);
            colorCode = 8;
        }
    }
}
