using UnityEngine;
using System.Collections;

public class generalEnemyBehaviour : MonoBehaviour {

    private bool attack;
    private bool attackPlayer;
    private float time;
    private GameObject player;
    private Animator anim;


    public float endTime;
    public float ms;
    public float dmg;



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Rotate();
        Move();
        Attack();
    }


    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            if (attackPlayer == true)
            {
                player.GetComponent<heroStats>().hp -= dmg;
                attackPlayer = false;
                Debug.Log("asd");
            }
        }

    }





    void Rotate()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 enemyPos = transform.position;

        if (playerPos.x <= enemyPos.x)
        {
            transform.rotation = Quaternion.AngleAxis(180f, Vector2.up);
        }
        else if (playerPos.x >= enemyPos.x)
        {
            transform.rotation = Quaternion.AngleAxis(0f, Vector2.up);
        }
    }

    void Move()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 50f && Vector3.Distance(transform.position, player.transform.position) > 2f)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, ms * Time.deltaTime);
            anim.SetBool("walk", true);
        }
    }

    void Attack()
    {


        if(Vector3.Distance(transform.position, player.transform.position) <= 2f)
        {
            attack = true;
        }

        

        if (attack == true)
        {
            time += Time.deltaTime;
            {
                if (time >= endTime)
                {
                    anim.SetTrigger("attack");
                    attack = false;
                    time = 0f;
                    attackPlayer = true;
                }
            }
        }
    }
}
