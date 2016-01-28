using UnityEngine;
using System.Collections;

public class fire_ball : MonoBehaviour {

    private Animator camera;
    private GameObject[] walls;
    private GameObject[] portals;
    private GameObject[] enemies;
    private int i;

    public GameObject dmg_text;
    public GameObject explosion;
    public float ms;
    public float dmg;


    void Awake()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
        walls = GameObject.FindGameObjectsWithTag("wall");
        portals = GameObject.FindGameObjectsWithTag("portal");
        enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

    void Update()
    {
        Movement();
    }

    void OnTriggerEnter(Collider col)
    {
        foreach (GameObject wall in walls)
        {
            if (col.gameObject == wall)
            {
                Instantiate(explosion, transform.position, transform.rotation * Quaternion.AngleAxis(180f, Vector3.up));
                Destroy(gameObject);
            }
        } foreach (GameObject portal in portals)
        {
            if (col.gameObject == portal)
            {
                Instantiate(explosion, transform.position, transform.rotation * Quaternion.AngleAxis(180f, Vector3.up));
                Destroy(gameObject);
            }
        }

        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                camera.SetTrigger("shake");

                Destroy(gameObject);
                enemy.GetComponent<enemy_behaviour>().health -= dmg;
                Instantiate(explosion, transform.position, transform.rotation * Quaternion.AngleAxis(180f, Vector3.up));

                //show text dmg when collides with enemys
                Dmg_shown_as_text();
            }
        }
    }

    void Movement()
    {
        transform.position += transform.forward * ms * Time.deltaTime;
    }

    void Dmg_shown_as_text()
    {
        dmg_text.GetComponent<TextMesh>().text = "" + dmg;
        Instantiate(dmg_text, transform.position, transform.rotation = Quaternion.Euler(new Vector3(65f,0,0)));
    }
}
