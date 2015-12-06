using UnityEngine;
using System.Collections;

public class enter_menu_obs : MonoBehaviour {

    private GameObject[] obstacles;
    private Vector3 starting_position;

    public GameObject death_particles;

    void Awake()
    {
        obstacles = GameObject.FindGameObjectsWithTag("obstacle");
    }

    void Start()
    {
        starting_position = transform.position;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject obstacle in obstacles)
        {
            if (col.gameObject == obstacle)
            {
                Instantiate(death_particles, transform.position, transform.rotation);
                transform.position = starting_position;
            }
        }
    }
}
