using UnityEngine;
using System.Collections;

public class rotate_right : MonoBehaviour {

    public float rs;

    void Update()
    {
        transform.Rotate(Vector3.forward * rs * Time.deltaTime);
    }

}
