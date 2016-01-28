using UnityEngine;
using System.Collections;

public class wall_movement : MonoBehaviour {

    private GameObject player;

    public float y;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            transform.position += new Vector3(0f, y, 0f);
        }
    }


}
