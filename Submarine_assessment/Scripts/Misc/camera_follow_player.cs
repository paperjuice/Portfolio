using UnityEngine;
using System.Collections;

public class camera_follow_player : MonoBehaviour {

    //Ionut Vericiu


    //camera will folow the player on x axis

    private GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");			//we take player tag 
    }

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = new Vector3(player.transform.position.x + 5f, transform.position.y, -10);		//transform the camera position
        }
    }
}
