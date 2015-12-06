using UnityEngine;
using System.Collections;

public class projectile_behaviour : MonoBehaviour {


    private GameObject player;

    public float ms;
    public float dmg_percentage;



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Movement();  
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == player)
        {
            player.GetComponent<hero_behaviour>().hp -= dmg_percentage / 100 * player.GetComponent<hero_behaviour>().hp;
            Destroy(gameObject);
        }
    }


    void Movement()
    {
        transform.position += transform.forward * ms * Time.deltaTime;
    }

}

