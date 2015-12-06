using UnityEngine;
using System.Collections;

public class pixie_shop_position : MonoBehaviour {

    private GameObject pixie_movement;


    void Awake()
    {
        pixie_movement = GameObject.FindGameObjectWithTag("pixie_movement");
    }

    void Update()
    {
        transform.position = pixie_movement.transform.position;
    }
    
}
