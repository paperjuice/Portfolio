using UnityEngine;
using System.Collections;

public class move_up_text_2 : MonoBehaviour {

    public float ms;


    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * ms;
    }
}
