using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

    private GameObject player;

    public float cameraSpeed;
    public float x;
    public float y;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + y, transform.position.z);
    }

    void LateUpdate()
    {
        CameraPos();
    }

    void CameraPos()
    {
        if (Input.GetKey("d"))
        {
            Vector3 posRight = new Vector3(player.transform.position.x + x, player.transform.position.y + y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, posRight, cameraSpeed* Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            Vector3 posRight = new Vector3(player.transform.position.x - x, player.transform.position.y + y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, posRight, cameraSpeed* Time.deltaTime);
        }
    }
}
