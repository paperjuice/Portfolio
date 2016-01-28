using UnityEngine;
using System.Collections;

public class horns_attacks : MonoBehaviour {

    private GameObject player;
    private bool activate;
    private float time;
    private float end_time = 2f;

    public float dmg;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player != null)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < 10)
            {
                activate = true;
                GetComponent<BoxCollider>().enabled = true;
            }
        }


        if (activate == true)
        {
            time += Time.deltaTime;

            if (time >= end_time)
            {
                GetComponent<BoxCollider>().enabled = false;
                activate = false;
                time = 0f;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == player)
        {
            player.GetComponent<hero_behaviour>().hp -= player.GetComponent<hero_behaviour>().max_hp*dmg/100;
           // print("asdasd");
        }
    }

}
