using UnityEngine;
using System.Collections;

public class coin_behaviour : MonoBehaviour {

    public float rs;

    void Update()
    {
        transform.Rotate(Vector3.up * rs * Time.deltaTime);
    }
}
