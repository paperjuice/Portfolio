using UnityEngine;
using System.Collections;

public class enemySimpleBehaviour : MonoBehaviour {

    private GameObject player;

    public float ms;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Quaternion currentPos = transform.rotation;


        if(player != null)
        { 
            transform.position  = Vector2.MoveTowards(transform.position, player.transform.position, ms * Time.deltaTime);
        }
       // currentPos.y = 0f;
    }
}
