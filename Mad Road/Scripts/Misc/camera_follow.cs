using UnityEngine;
using System.Collections;

public class camera_follow : MonoBehaviour {

    private GameObject player;
    private Vector3 target;

    public float x;
    public float y;
    public float z;



    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        if (player != null)
        {
            target = new Vector3(player.transform.position.x + x, player.transform.position.y + y, player.transform.position.z + z);

            transform.position = Vector3.Slerp(transform.position, target, Time.deltaTime * 6f);
        }
    }


}
