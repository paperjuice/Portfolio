using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

    private GameObject player;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }
}
