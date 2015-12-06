using UnityEngine;
using System.Collections;

public class mine : MonoBehaviour {

    private GameObject player;
    private GameObject wall;
    private Rigidbody2D rigid;

    public GameObject soundDestro;
    public GameObject destroPart;
    public string oppositePlayerTag;
    public int dmg;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag(oppositePlayerTag);
        wall = GameObject.FindGameObjectWithTag("wall");
        rigid = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rigid.AddForce(transform.up * 10);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            player.GetComponent<playerSts>().health -= dmg;
            Instantiate(destroPart, transform.position, transform.rotation);
            Instantiate(soundDestro, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        if (col.gameObject == wall)
        {
            Destroy(gameObject);
            Instantiate(soundDestro, transform.position, transform.rotation);
            Instantiate(destroPart, transform.position, transform.rotation);
        }
    }
}
