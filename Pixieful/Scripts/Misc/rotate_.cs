using UnityEngine;
using System.Collections;

public class rotate_ : MonoBehaviour {

    public float rs;

    void Update()
    {
        transform.Rotate(Time.deltaTime * rs * transform.forward);
    }
}
