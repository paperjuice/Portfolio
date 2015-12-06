using UnityEngine;
using System.Collections;

public class heroBehaviour : MonoBehaviour {

    private Animator anim;
    private Rigidbody2D rigid;
    private GameObject[] grounds;


    //stats
    public float cs;    //curent speed
    public float ms;
    public float ss;   //sprint speed
    public float jp;   //jump power

    //movement bools
    public bool moveLeft;
    public bool moveRight;
    public bool sprint;
    public bool jump;
    private bool onGround;


    void Awake()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();

        grounds = GameObject.FindGameObjectsWithTag("ground");
    }

    void Start()
    {
        cs = ms;
    }

    void Update()
    {
        Movement();
    }

    void OnCollisionStay2D(Collision2D col)
    {
        foreach (GameObject ground in grounds)
        {
            if (col.gameObject == ground)
            {
                onGround = true;
            }
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        foreach (GameObject ground in grounds)
        {
            if (col.gameObject != ground)
            {
                onGround = false;
            }
        }
    }



    void Movement()
    {
        if (Input.GetKey("a"))
        {
            moveLeft = true;
            transform.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
          //  transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            moveLeft = false;
        }

        if (Input.GetKey("d"))
        {
            moveRight = true;
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
           // transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            moveRight = false;
        }


        //activate walk animation + walk obj
        if (moveLeft == true || moveRight == true)
        {
            anim.SetBool("walk", true);
            transform.position += transform.right * cs * Time.deltaTime;
        }
        else
        {
            anim.SetBool("walk", false);
        }


        //activate run + run obj
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprint = true;
        }
        else
        {
            sprint = false;
        }

        if (moveLeft == true || moveRight == true)
        {
            if (sprint == true)
            {
                anim.SetBool("run", true);
                cs = ss; 
            }
            else
            {
                anim.SetBool("run", false);
                cs = ms;
            }
        }
        else if(moveLeft == false && moveRight == false)
        {
            anim.SetBool("run", false);
            cs = ms;
        }
        


        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onGround == true)
            {
                anim.SetTrigger("jump");
                rigid.AddForce(new Vector2(0f, 1f) * jp);
            }
        }



    }
}
