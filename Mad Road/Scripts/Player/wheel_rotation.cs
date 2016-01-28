using UnityEngine;
using System.Collections;

public class wheel_rotation : MonoBehaviour {

    public float ms;

    void Update()
    {
        transform.Rotate(Vector3.right * ms * Time.deltaTime);
    }
}
