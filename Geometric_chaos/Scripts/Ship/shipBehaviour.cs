using UnityEngine;
using System.Collections;

public class shipBehaviour : MonoBehaviour {

    public float ms;
    public float rs;



    private GameObject[] spawners;
    private GameObject[] walls;
    private GameObject cursor;
    private Rigidbody2D rigid;
    private bool rotRight;
    private RaycastHit raycast;
    private float dist = 1000f;
    private int mask;
    private LineRenderer line;
    private Ray rayPos;
    private bool moveRight = false;
    private Vector3 targetPosition;
    private Vector3 targetRotation;



    void Awake()
    {
        walls = GameObject.FindGameObjectsWithTag("wall");
        spawners = GameObject.FindGameObjectsWithTag("spawner");
        cursor = GameObject.FindGameObjectWithTag("cursor");

        rigid = GetComponent<Rigidbody2D>();

        mask = LayerMask.GetMask("floor");
        line = GetComponent<LineRenderer>();
    }


    void Update()
    {        
        Move();
        Rotate();

        //Move_v2();

        //Move_v3();

       //Move_v4();

        //Move_v5();

        //Move_v6();

        //Move_v7();

       // Move_v8();

        //Move_v9();
     }




    void OnCollisionEnter2D(Collision2D col)
    {
        foreach (GameObject wall in walls)
        {
            if (col.gameObject == wall)
            {
                GetComponent<shipSts>().hp = 0f;
            }
        }

        foreach (GameObject spawner in spawners)
        {
            if (col.gameObject == spawner)
            {
                GetComponent<shipSts>().hp = 0f;
            }
        }
    }

    void Move()
    {
        transform.position += transform.up * ms * Time.deltaTime;
    }

    void Move_v2()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (moveRight == false)
            {
                moveRight = true;
            }
            else if (moveRight == true)
            {
                moveRight = false;
            }
        }


        if (moveRight == false)
        {
            transform.Rotate(Vector3.forward * -rs * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.forward * rs * Time.deltaTime);
        }


    }

    void Rotate()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            rotRight = true;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            rotRight = false;
        }

        //////

        if(rotRight == true)
        {
            transform.Rotate(Vector3.forward * rs * Time.deltaTime);
        }
        else if (rotRight == false)
        {
            transform.Rotate(Vector3.forward * -rs * Time.deltaTime);
        }
    }

    void Move_v3()
    {
        if (Input.GetKey(KeyCode.I))
        {
            transform.Rotate(Vector3.forward * rs * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.P))
        {
            transform.Rotate(Vector3.forward * -rs * Time.deltaTime);
        }


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        Vector3 move = new Vector3(h, v, 0f) * ms * Time.deltaTime;

        transform.position += move; 
    }

    void Move_v4()
    { 
        //rotation
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D raycastHit =  Physics2D.Raycast(camRay.origin, camRay.direction, dist, mask);
        {

            if(raycastHit)
            {
                Debug.Log("asd");
            }
                // Debug.Log(camRay.GetPoint(10000f));
            transform.rotation = Quaternion.FromToRotation(transform.position, -raycastHit.point);
        }


        //movement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        Vector3 move = new Vector3(h, v, 0f) * ms * Time.deltaTime;

        transform.position += move; 
    }

    void Move_v5()
    { 
        //rotate

        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D rayHit = Physics2D.GetRayIntersection(camRay, dist, mask);
        if (rayHit)
        {
            //Debug.Log(rayHit.point);
            transform.rotation = Quaternion.FromToRotation(-transform.position, rayHit.point);
        }

      /*  //movement
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.up * ms * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            transform.position -= Vector3.up * ms * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            transform.position -= Vector3.right * ms * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * ms * Time.deltaTime;
        }

        Cursor.visible = false; */

        transform.position = Vector3.MoveTowards(transform.position, rayHit.point, ms * Time.deltaTime);
    }

    void Move_v6()
    { 
        //rotate
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(camRay, out raycast, dist, mask))
        {
            Vector3 rotate = -raycast.point - transform.position;
          //  rotate.y = 0f;

            transform.rotation = Quaternion.FromToRotation(transform.position, rotate );
        }


        //move
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.up * ms * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            transform.position -= Vector3.up * ms * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            transform.position -= Vector3.right * ms * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * ms * Time.deltaTime;
        }

        Cursor.visible = false;
    }

    void Move_v7()
    {

        //rotate
        transform.rotation = Quaternion.FromToRotation(-transform.position, cursor.transform.position);

        //move
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        Vector3 move = new Vector3(h, v, 0f) * ms * Time.deltaTime;

        transform.position += move; 

        Cursor.visible = false;
    }

    void Move_v8()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(camRay, out raycast, dist, mask))
            {
                targetPosition = raycast.point;

            }
        }
        if (transform.position != targetPosition)
        {
              transform.position = Vector3.MoveTowards(transform.position, targetPosition, ms * Time.deltaTime);
             // transform.Rotate((targetPosition - transform.position) * Time.deltaTime * 10 + Vector3.right);
              //Vector3 asd = targetPosition - transform.position;
             

              transform.rotation = Quaternion.LookRotation(targetPosition);
        }
   
    }


    void Move_v9()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(camRay, out raycast, dist, mask))
        {
            targetPosition = transform.position - raycast.point ;

            
        }

        transform.LookAt(targetPosition);
    }





}
