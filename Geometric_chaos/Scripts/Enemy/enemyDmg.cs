using UnityEngine;
using System.Collections;

public class enemyDmg : MonoBehaviour {

    private GameObject camera;
    private GameObject player;
    private BoxCollider2D collider;

    public GameObject particles;
    public float dmg;



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        collider = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (collider.isTrigger == false)
        {
            if (col.gameObject == player)
            {
                player.GetComponent<shipSts>().hp -= dmg;
                //Destroy(gameObject);
                GetComponent<enemySts>().hp = 0f;
                Instantiate(particles, transform.position, transform.rotation);
                camera.GetComponent<Animator>().SetTrigger("shake");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (collider.isTrigger == true)
        {
            if (col.gameObject == player)
            {
                player.GetComponent<shipSts>().hp -= dmg;
               // Destroy(gameObject);
                GetComponent<enemySts>().hp = 0f;
                Instantiate(particles, transform.position, transform.rotation);
                camera.GetComponent<Animator>().SetTrigger("shake");
            }
        }
    }

    

}
