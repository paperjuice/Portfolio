using UnityEngine;
using System.Collections;

public class camera_behaviour : MonoBehaviour {

    private GameObject player;
    private float curent_y_position;


    public float y;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {
        curent_y_position = player.transform.position.y;
        transform.position = new Vector3(transform.position.x, player.transform.position.y+y, -10);
    }

    void FixedUpdate()
    {
        if (player != null)
        {
            if (curent_y_position <= player.transform.position.y)
            {
                Vector3 target = new Vector3(transform.position.x, player.transform.position.y + y, -10);

                transform.position = Vector3.Lerp(transform.position, target, 2f * Time.deltaTime);
                curent_y_position = player.transform.position.y;
            }
        }
    }
}
