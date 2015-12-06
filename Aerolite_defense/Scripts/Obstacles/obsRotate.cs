using UnityEngine;
using System.Collections;

public class obsRotate : MonoBehaviour {

    private float rs;

    void Start()
    {
        rs = Random.Range(-5f, 5f);
    }

    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        transform.Rotate(Vector3.forward * rs);
    }
}
