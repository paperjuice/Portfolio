using UnityEngine;
using System.Collections;

public class text_up_movement : MonoBehaviour {

    public float ms;

    void Update()
    {
        transform.position += Vector3.up * ms * Time.deltaTime;
    }
}
