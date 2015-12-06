using UnityEngine;
using System.Collections;

public class mainMenuObs : MonoBehaviour {

    private GameObject camera;

    public GameObject part_destro;
    public GameObject sound_destro;
    public float ms;

    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");

        float r = Random.Range(0.02f, 0.08f);

        transform.position += new Vector3(Random.Range(-5f, 5f), 0f, 0f);
        transform.localScale = new Vector3(r,r,r);
        transform.rotation = Quaternion.AngleAxis(140f, Vector3.forward);
    }

    void Update()
    {
        Move();   
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //shake animation
        camera.GetComponent<Animator>().SetTrigger("shake");
        part_destro.GetComponent<ParticleSystem>().startColor = GetComponent<SpriteRenderer>().color;
        Instantiate(part_destro, transform.position, transform.rotation);
        Instantiate(sound_destro, transform.position, transform.rotation);
        Destroy(gameObject);
    }
        

    void Move()
    {
        transform.position += transform.up * ms * Time.deltaTime;
    }
}
