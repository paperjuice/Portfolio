using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

    public float rs;


    void Update()
    {
        transform.Rotate(rs * Vector3.forward);
    }
}
