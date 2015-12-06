using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {


    private float r;
    public float rs;


    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        transform.Rotate(Vector3.forward * rs);
    }
}
