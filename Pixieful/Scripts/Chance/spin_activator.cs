using UnityEngine;
using System.Collections;

public class spin_activator : MonoBehaviour {

    public GameObject activate_spin;

    //save the initial color
    private Color initial_col;
    private Color col;
    private float time;
    private float end_time = 5f;

    //after you tap the spin button, the wheel spins for an amount of time, time in which you wont be able to press the spin button again
    //when spin_time == true, you will be able to press again;
    private bool spin_time;

    void Awake()
    {
        col = GetComponent<SpriteRenderer>().color;
    }

    void Start()
    {
        initial_col = GetComponent<SpriteRenderer>().color;
    }

    void OnMouseDown()
    {
        if (tokkens.tokken > 0)
        {
            activate_spin.GetComponent<pointer_v2>().start_spin = true;
            tokkens.tokken--;
            GetComponent<BoxCollider2D>().enabled = false;
            PlayerPrefs.SetInt("tokkens", tokkens.tokken);

            //change color so you know you can t press the button;
            GetComponent<SpriteRenderer>().color = Color.gray;

            spin_time = true;

        }
    }

    void Update()
    {
        if (spin_time == true)
        {
            time += Time.deltaTime;

            if (time >= end_time)
            {
                GetComponent<BoxCollider2D>().enabled = true;
                time = 0;
                spin_time = false;
                GetComponent<SpriteRenderer>().color = col;
            }
        }
    }
}
