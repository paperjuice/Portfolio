using UnityEngine;
using System.Collections;

public class enemy_behaviour : MonoBehaviour {

    private GameObject player;
    private GameObject camera_;
    private GameObject[] projectiles;
    private GameObject[] walls;
   // private GameObject portal;                //place to respawn
    private float time;
    private float end_time_dodge=1f;        //time assigned to enemy to dodge wall
    private Rigidbody rigid;
    private Vector3 starting_position;      //the 3 coordniates that dictates my starting position

    private float starting_health;

    private RaycastHit raycast;

    public GameObject soul;
    public GameObject death_particle;

    //it goes into Death_by_friend
    public bool friendly_fire;    

    //if the enemy is range or not
    public bool is_range = false;

    public float dodge_power;
    public int dodge_chance;

    public float ms;
    public float starting_ms;

    public float rs;
    public float health;

    public bool follow = true;          //check fi player is followed


    void Awake()
    {
        starting_position = transform.position;
       

        rigid = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        camera_ = GameObject.FindGameObjectWithTag("MainCamera");
        walls = GameObject.FindGameObjectsWithTag("wall");
       // portal = GameObject.FindGameObjectWithTag("portal");
    }

    IEnumerator Start()
    {
        starting_health = health;
        starting_ms = ms;

        while(true)
        {
            projectiles = GameObject.FindGameObjectsWithTag("projectile");
            yield return new WaitForSeconds(0.1f);
        }

    }

    void Update()
    {
        LookAtHero();
        Movement();
        Death();
        Dodge_projectile();
        Wall_Dodge();
        Death_by_friend();
    }

    void LookAtHero()
    {
        if (follow == true)
        {
            if (player != null)
            {
                //  Vector3 player_position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
                // transform.LookAt(player_position);

                Vector3 asd = player.transform.position - transform.position;
                asd.y = 0f;
                Quaternion dfg = Quaternion.LookRotation(asd);
                transform.rotation = Quaternion.Lerp(transform.rotation, dfg, Time.deltaTime*2f);
            }
        }
    }

    void Movement()
    {
        if (is_range == false)
        {
            if (player != null)
            {
                transform.position += transform.forward * ms * Time.deltaTime;
            }
        }

        if (is_range == true)
        {
            if (player != null)
            {
                if (Vector3.Distance(transform.position, player.transform.position) > 15f)
                {
                    transform.position += transform.forward * ms * Time.deltaTime;
                }
                if (Vector3.Distance(transform.position, player.transform.position) < 10f)
                {
                    transform.position -= transform.forward * ms * Time.deltaTime;
                }
            }
        }
    }

    void Death()
    {
        if (health <= 0)
        {
            Instantiate(soul, transform.position, transform.rotation *= Quaternion.Euler(0f, Random.Range(0f, 180f), 0f));
            Instantiate(soul, transform.position, transform.rotation *= Quaternion.Euler(0f, Random.Range(0f, 180f), 0f));
           // camera_.GetComponent<Animator>().SetTrigger("shake");
            Instantiate(death_particle, transform.position, transform.rotation);
            transform.position = starting_position;              
            health = starting_health;
            ms = starting_ms;   
        }
    }

    void Dodge_projectile()
    {
        int r = 0;          //dodge chance
        int x = 0;          //left or right dash direction

        foreach(GameObject projectile in projectiles)
        {
            if (projectile != null)
            {
                if (Vector3.Distance(transform.position, projectile.transform.position) < 10f)
                {
                    //chance to dodge
                    r = Random.Range(1, dodge_chance);                                                     
                }
            }
        }

        if (r == 2)
        {

            x = Random.Range(1, 3);

            if (x == 1)
            {
                rigid.AddForce(transform.right * dodge_power * 1000f);
                x = 0;
            }
            else if (x == 2)
            {
                rigid.AddForce(transform.right * dodge_power * -1000f);
                x = 0;
            }

            r = 0;
        }
    }


    void Wall_Dodge()
    {
        foreach (GameObject wall in walls)
        {

            if (Physics.Raycast(transform.position, transform.forward, out raycast, 3f))
            {

                if (raycast.collider.gameObject == wall)
                {
                    follow = false;
                }
            }
        }


        if (follow == false)
        {
            time += Time.deltaTime;
            

            if (time <= end_time_dodge)
            {
                transform.Rotate(Vector3.up * Time.deltaTime * rs * 1.5f);
            }

           else  if(time>3)
            {
                follow = true;
                time = 0f;
            }
        }
    }


    //death that is not caused by the player
    //death caused by enemy
    void Death_by_friend()
    { 
        if(friendly_fire == true)
        {
           // Instantiate(death_particle, transform.position, transform.rotation);
           // transform.position = starting_position;
           // health  = starting_health;

            rigid.AddForce((transform.forward+transform.up) * -200000);
            friendly_fire = false;
        }
    }



}

