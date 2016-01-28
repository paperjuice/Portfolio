using UnityEngine;
using System.Collections;

public class ground_reuse : MonoBehaviour {

    private GameObject player;

    public float z;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == player)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y , transform.position.z + z);
        }
    }
}
