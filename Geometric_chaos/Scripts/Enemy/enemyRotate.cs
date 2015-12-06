using UnityEngine;
using System.Collections;

public class enemyRotate : MonoBehaviour {

    public float rs;


    void Update()
    {
        transform.Rotate(Vector3.forward * rs);
    }
}
