using UnityEngine;
using System.Collections;

public class camera_follow_player : MonoBehaviour {

    private GameObject player;

    public float y;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, y, transform.position.z);
    }
}
