using UnityEngine;
using System.Collections;

public class hero_movement : MonoBehaviour {

    private GameObject floor;
    private Rigidbody rigid;
    public bool on_ground = false;

    //rotate stats
    private int layerMask;
    private float dist = 1000f;
    private RaycastHit raycast;


    //keys control
    public KeyCode move_up;
    public KeyCode move_right;
    public KeyCode move_left;
    public KeyCode move_down;

    public float ms;


    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        floor = GameObject.FindGameObjectWithTag("floor");

        layerMask = LayerMask.GetMask("floor");
    }

    void FixedUpdate()
    {
        //Movement();
        Movement_v2();
        //Movement_v3();
        Rotate();
    }

    void Update()
    {
        Gravity();
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject == floor)
        {
            on_ground = true;
        }
    }
    void OnCollisionExit()
    {
        on_ground = false;
    }

    void Gravity()
    {
        if (on_ground == false)
        {
            transform.position -= Vector3.up * Time.deltaTime * 9f;
        }
    }

    void Movement()
    {

        if (Input.GetKey(move_up))
        {
            //rigid.MovePosition(transform.position + Vector3.forward * ms * Time.fixedDeltaTime);
            transform.position += Vector3.forward * ms * Time.deltaTime;
        }

        if (Input.GetKey(move_down))
        {
            //rigid.MovePosition(transform.position - Vector3.forward * ms * Time.fixedDeltaTime);
            transform.position -= Vector3.forward * ms * Time.deltaTime;
        }

        if (Input.GetKey(move_right))
        {
            //rigid.MovePosition(transform.position + Vector3.right * ms * Time.fixedDeltaTime);
            transform.position += Vector3.right * ms * Time.deltaTime;
        }

        if (Input.GetKey(move_left))
        {
            //rigid.MovePosition(transform.position - Vector3.right * ms * Time.fixedDeltaTime);
            transform.position -= Vector3.right * ms * Time.deltaTime;
        }
    }

    void Movement_v2()
    {
        if (Input.GetKey(move_up))
        {
            rigid.AddForce(Vector3.forward * ms * 1000);
        }

        if (Input.GetKey(move_down))
        {
            rigid.AddForce(Vector3.forward * -ms * 1000);
        }

        if (Input.GetKey(move_right))
        {
            rigid.AddForce(Vector3.right * ms * 1000);
        }

        if (Input.GetKey(move_left))
        {
            rigid.AddForce(Vector3.right * -ms * 1000);
        }
    }


    void Movement_v3()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(h, 0, v);
        movement = movement.normalized * ms * Time.deltaTime;
        rigid.MovePosition(transform.position + movement);

    }

    void Rotate()
    {
        Ray mouse = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(mouse, out raycast, dist, layerMask))
        {

            Vector3 playerToMouse = raycast.point - transform.position;
            playerToMouse.y = 0f;

            transform.rotation = Quaternion.LookRotation(playerToMouse);


        }

    }

    

}
