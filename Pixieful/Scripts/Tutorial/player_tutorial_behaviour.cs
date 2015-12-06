using UnityEngine;
using System.Collections;

public class player_tutorial_behaviour : MonoBehaviour {

    private GameObject wall;
    private Vector3 starting_pos;
    private bool disabled;

    private float time;
    private float end_time = 0.5f;

    public GameObject dont_touch_text;

    void Start()
    {
        starting_pos = transform.position - new Vector3(0, 5, 0);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        wall = GameObject.FindGameObjectWithTag("wall");

        if (col.gameObject == wall)
        {
            Instantiate(dont_touch_text, transform.position, transform.rotation);
            transform.position = starting_pos;
            disabled = true;
        }
    }

    void Update()
    {
        if (disabled == true)
        {
            GetComponent<position_on_area>().enabled = false;
            time += Time.deltaTime;

            if (time >= end_time)
            {
                GetComponent<position_on_area>().enabled = true;
                disabled = false;
                time = 0f;
            }
        }

    }
}
