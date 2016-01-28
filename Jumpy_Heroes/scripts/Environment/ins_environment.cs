using UnityEngine;
using System.Collections;

public class ins_environment : MonoBehaviour {

    private GameObject player;

    public GameObject wall_1;
    public float y;
    public float wall_y;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            print("asdasdasd");
            Instantiate(wall_1, transform.position += new Vector3(wall_1.transform.position.x, wall_y, 0f), transform.rotation);
           // transform.position += new Vector3(0f, y, 0f);
        }
    }
}
