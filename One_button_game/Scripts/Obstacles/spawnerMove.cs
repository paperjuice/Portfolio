using UnityEngine;
using System.Collections;

public class spawnerMove : MonoBehaviour {

    public float ms;


    void Update()
    {
        transform.position += transform.right * ms * Time.deltaTime;
        ms += Time.deltaTime * 0.3f;
    }
}
