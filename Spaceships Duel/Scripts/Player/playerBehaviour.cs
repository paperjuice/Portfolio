using UnityEngine;
using System.Collections;

public class playerBehaviour : MonoBehaviour {


    private GameObject wall;
    private GameObject player;
    
    private bool moveRight = false;

    public string oppositePlayerTag;
    public KeyCode moveKey;
    public float ms;
    public float rs;



    void Awake()
    {
        wall = GameObject.FindGameObjectWithTag("wall");
        player = GameObject.FindGameObjectWithTag(oppositePlayerTag);
    }

    void Update()
    {
        Rotate();
        Move();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == wall)
        {
            GetComponent<playerSts>().health -= 90000;
        }

        if (col.gameObject == player)
        {
            GetComponent<playerSts>().health -= 90000;
            player.GetComponent<playerSts>().health -= 90000;
        }
    }


    void Rotate()
    { 
        if(Input.GetKey(moveKey))
        {
            moveRight = true;
        }
        else
        {
            moveRight = false;
        }


        if (moveRight == true)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rs);
        }
        else
        {
            transform.Rotate(Vector3.forward  * Time.deltaTime * -rs);
        }
    }

    void Move()
    {
        transform.position += transform.up * ms * Time.deltaTime;
    }


}
