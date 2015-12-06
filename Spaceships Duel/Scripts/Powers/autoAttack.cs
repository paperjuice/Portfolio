using UnityEngine;
using System.Collections;

public class autoAttack : MonoBehaviour {

    private GameObject player;
    private GameObject wall;

    public GameObject soundDestro;
    public GameObject destroyParticles;
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
            Instantiate(destroyParticles, transform.position, transform.rotation);
            Instantiate(soundDestro, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (col.gameObject == wall)
        {
            Instantiate(destroyParticles, transform.position, transform.rotation);
            Instantiate(soundDestro, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void Movement()
    {
        transform.position += transform.up * Time.deltaTime * ms;
    }
}
