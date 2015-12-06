using UnityEngine;
using System.Collections;

public class gem_behaviour : MonoBehaviour {

    public float min_power;
    public float max_power;
    public float rs;

    private GameObject player;
    private Rigidbody rigid;
    private int x = 1;              //check bling as visible/invisible
    private float bling_time;
    private float time;
    private float end_time = 0.3f;


    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {
        rigid.AddForce((transform.right + transform.up) * Random.Range(min_power, max_power));
    }


    void Update()
    {
        Rotate();
        Bling();
        Move_towards_player();
    }

    void Rotate()
    {
        transform.Rotate(rs * Time.deltaTime * Vector3.up);
    }

    void Bling()
    {
        
        bling_time += Time.deltaTime;

        if (bling_time > 10)
        {
            time += Time.deltaTime;

            if (time > end_time)
            {
                x *= -1;
                time = 0f;
            }
        }

        if (x == -1)
        {
            GetComponent<MeshRenderer>().enabled = false;
        }
        else if (x == 1)
        {
            GetComponent<MeshRenderer>().enabled = true;
        }


        if (bling_time > 15)
        {
            Destroy(gameObject);
        }
    }

    void Move_towards_player()
    {
        if (player != null)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < 10f)
            {
                //rigid.AddForce((player.transform.position - transform.position) * 6f);

                Vector3 target = player.transform.position;
                //transform.position = Vector3.Slerp(transform.position, target, Time.deltaTime * 3f);
                transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 10f);
            }
        }
    }
}
