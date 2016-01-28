using UnityEngine;
using System.Collections;

public class player_behaviour : MonoBehaviour {

    private GameObject r_wall;
    private GameObject l_wall;
    private GameObject controller;

    private GameObject[] enemies;
    private Rigidbody2D rigid;
    private GameObject camera_;

    public GameObject hand;

    [SerializeField]
    private GameObject trail;

    private bool start_move = false;
    [SerializeField]
    public GameObject player_death_part;
    [SerializeField]
    private float ms = 2f;
    private int direction = -1;

    



    void Awake()
    {
        r_wall = GameObject.FindGameObjectWithTag("right_wall"); 
        l_wall = GameObject.FindGameObjectWithTag("left_wall");
        controller = GameObject.FindGameObjectWithTag("controller");
        camera_ = GameObject.FindGameObjectWithTag("MainCamera");
        rigid = GetComponent<Rigidbody2D>();
    }

    IEnumerator Start()
    {
        while (true)
        {
            enemies = GameObject.FindGameObjectsWithTag("enemy");

            yield return new WaitForSeconds(0.1f);
        }
    }

    void Update()
    {
        Start_movement();
        Movement();
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject == r_wall)
        {
            trail.gameObject.SetActive(false);
            transform.position = new Vector3(-3f, -3, transform.position.z);
        }

        if (col.gameObject == l_wall)
        {
            trail.gameObject.SetActive(false);
            transform.position = new Vector3(3f, -3, transform.position.z);
        }
    }

    IEnumerator OnCollisionExit2D()
    {
        yield return new WaitForSeconds(0.17f);
        trail.gameObject.SetActive(true);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                camera_.GetComponent<Animator>().SetTrigger("shake");
                Instantiate(player_death_part, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }



    void Start_movement()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            start_move = true;
            hand.gameObject.SetActive(false);
            controller.GetComponent<controller>().start = true;
        }
    }

    void Movement()
    {
        if (start_move == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                direction *= -1;
            }
            //transform.position += Vector3.right * ms * Time.deltaTime * direction;
            rigid.AddForce(Vector3.right * ms * direction);
        }
    }





}
