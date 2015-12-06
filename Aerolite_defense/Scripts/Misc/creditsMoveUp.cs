using UnityEngine;
using System.Collections;

public class creditsMoveUp : MonoBehaviour {



    public float ms;

    void Update()
    {
        transform.position += Vector3.up * ms * Time.deltaTime;
    }


}
