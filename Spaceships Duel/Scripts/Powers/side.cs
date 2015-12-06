using UnityEngine;
using System.Collections;

public class side : MonoBehaviour {

    private GameObject player;
    private GameObject wall;

    public GameObject soundDestro;
    public GameObject destroParticle;
    public string oppositePlayerTag;
    public float ms;
    public int dmg;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag(oppositePlayerTag);
        wall = GameObject.FindGameObjectWithTag("wall");
    }

    void Update()
    {
        Movement();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            player.GetComponent<playerSts>().health -= dmg;
            Destroy(gameObject);
            Instantiate(destroParticle, transform.position, transform.rotation);
            Instantiate(soundDestro, transform.position, transform.rotation);
        }

        if (col.gameObject == wall)
        {
            Destroy(gameObject);
            Instantiate(destroParticle, transform.position, transform.rotation);
            Instantiate(soundDestro, transform.position, transform.rotation);
        }
    }

    void Movement()
    {
        transform.position += transform.right * Time.deltaTime * ms;
    }



}
