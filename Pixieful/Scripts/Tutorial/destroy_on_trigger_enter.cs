using UnityEngine;
using System.Collections;

public class destroy_on_trigger_enter : MonoBehaviour {

    private GameObject player;

    public GameObject obstacle;
    public GameObject tut_5;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            Destroy(gameObject);
            obstacle.gameObject.SetActive(true);
            tut_5.gameObject.SetActive(true);
        }
    }
}
