using UnityEngine;
using System.Collections;

public class bricks_random_pos : MonoBehaviour {




    void Start()
    {
        transform.localPosition = new Vector3(Random.Range(-3.5f, 3.5f), transform.localPosition.y, transform.localPosition.z);
    }
}
