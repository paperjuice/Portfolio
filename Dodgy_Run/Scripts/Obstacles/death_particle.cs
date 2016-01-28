using UnityEngine;
using System.Collections;

public class death_particle : MonoBehaviour {

    [SerializeField]
    private GameObject enemy_death_particle;
    private GameObject ground;

    void Awake()
    {
        ground = GameObject.FindGameObjectWithTag("ground");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == ground)
        {
            Instantiate(enemy_death_particle, transform.position = new Vector3(transform.position.x, transform.position.y - 0.2f, transform.position.z), enemy_death_particle.transform.rotation);
        }
    }
}
