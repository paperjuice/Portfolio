using UnityEngine;
using System.Collections;

public class enemySts : MonoBehaviour {



    private GameObject player;


    public GameObject particles;
    public GameObject prize;
    public float hp;
    public float xpGiven;



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {
        Death();
        Prize();
    }

    void Death()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
            Instantiate(particles, transform.position, transform.rotation);
            player.GetComponent<shipSts>().currentXp += xpGiven;
 
        }

    }


    void Prize()
    {
        if (hp <= 0)
        {
            Instantiate(prize, transform.position, transform.rotation);
        }
    }

}
