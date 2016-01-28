using UnityEngine;
using System.Collections;

public class life_time : MonoBehaviour {

    public float time;

    void Start()
    {
        Destroy(gameObject, time);
    }
}
