using UnityEngine;
using System.Collections;

public class life_time : MonoBehaviour {

	//how long an object destroyed will stay alive

    public float time;

    void Start()
    {
        Destroy(gameObject, time);
    }
}
