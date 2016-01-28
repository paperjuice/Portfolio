using UnityEngine;
using System.Collections;

public class player_behaviour : MonoBehaviour
{

    private bool move_left = false;
    private bool fly = true;
    private Rigidbody rigid;
    private GameObject text;
    private GameObject camera_;
    private GameObject[] rocks;
    private GameObject[] grounds;
    private GameObject[] coins;
    private GameObject[] great_coins;


    //gravity power
    //public float gp;
    public GameObject wheel_part_1;
    public GameObject wheel_part_2;
    public GameObject coin_part;
    public GameObject great_coin_part;
    public GameObject death_particles;
    public float score = 0;
    public float ms;
    public float rs;



    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        grounds = GameObject.FindGameObjectsWithTag("ground");
        text = GameObject.FindGameObjectWithTag("text");
        camera_ = GameObject.FindGameObjectWithTag("MainCamera");
        
    }

    IEnumerator Start()
    {
        while (true)
        {
            coins = GameObject.FindGameObjectsWithTag("coin");
            great_coins = GameObject.FindGameObjectsWithTag("great_coin");
            rocks = GameObject.FindGameObjectsWithTag("rock");

            yield return new WaitForSeconds(0.1f);
        }
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            move_left = true;
        }
        else
        {
            move_left = false;
        }

        Movement();
        Rotate();
        Show_score_text();
    }


    void OnTriggerEnter(Collider col)
    {
        foreach (GameObject coin in coins)
        {
            if (col.gameObject == coin)
            {
                Instantiate(coin_part, transform.position, transform.rotation);
                Destroy(coin.gameObject);
                score++;
            }
        }
        
        foreach (GameObject great_coin in great_coins)
        {
            if (col.gameObject == great_coin)
            {
                Instantiate(great_coin_part, transform.position, transform.rotation);
                Destroy(great_coin.gameObject);
                score+=5;
            }
        }

    }

    void OnCollisionEnter(Collision col)
    {
        foreach (GameObject rock in rocks)
        {
            if (col.gameObject == rock)
            {
                Instantiate(death_particles, transform.position, death_particles.transform.rotation);
                camera_.GetComponent<Animator>().SetTrigger("shake");
                Destroy(gameObject);
            }
        }
    }

    void OnCollisionStay(Collision col)
    {
        foreach (GameObject ground in grounds)
        {
            if (col.gameObject == ground)
            {
                wheel_part_1.GetComponent<ParticleSystem>().startSize = 0.4f;
                wheel_part_2.GetComponent<ParticleSystem>().startSize = 0.4f;
            }
        }
    }
    void OnCollisionExit(Collision col)
    {
        foreach (GameObject ground in grounds)
        {
            if (col.gameObject == ground)
            {
                wheel_part_1.GetComponent<ParticleSystem>().startSize = 0f;
                wheel_part_2.GetComponent<ParticleSystem>().startSize = 0f;
            }
        }
    }


    void Movement()
    {
        if (ms <= 21.5f)
        {
            ms += Time.deltaTime * 0.2f;
        }


        transform.position += transform.forward * ms * Time.deltaTime;
        //rigid.MovePosition((transform.forward * ms * Time.deltaTime)+ transform.position);
    }

    void Rotate()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);


        if (rs <= 70)
        {
            rs += Time.deltaTime * 0.5f;
        }


        if (move_left == true)
        {
            transform.Rotate(transform.up * rs * Time.deltaTime);
        }
        else
        {
            transform.Rotate(transform.up * -rs * Time.deltaTime);
        }
    }


    void Show_score_text()
    {
        text.GetComponent<TextMesh>().text = "MadCoins: " + score; 
    }
}
