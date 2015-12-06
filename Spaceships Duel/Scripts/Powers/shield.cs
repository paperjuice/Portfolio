using UnityEngine;
using System.Collections;

public class shield : MonoBehaviour {


    private GameObject player;
    private GameObject projectile;

    public GameObject projectileDesto_part;
    public string oppositeProjectileTag;
    public string playerTag;
    public float inflate_speed;
    public float deathTime;



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag(playerTag);
        projectile = GameObject.FindGameObjectWithTag(oppositeProjectileTag);
    }

    void Start()
    {
        Destroy(gameObject, deathTime);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == projectile)
        {
            Instantiate(projectileDesto_part, transform.position, transform.rotation);
            Destroy(projectile.gameObject);
        }
    }

    void Update()
    {
        Scale();
        Position();
    }


    void Scale()
    {
        transform.localScale += new Vector3(1f, 1f, 1f) * Time.deltaTime * inflate_speed;
    }


    void Position()
    {
        if(player != null)
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }

}
