using UnityEngine;
using System.Collections;

public class health_bar_billboard : MonoBehaviour {

    private GameObject camera_;


    void Awake()
    {
        camera_ = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        transform.LookAt(camera_.transform.position);
        transform.Rotate(new Vector3(0, 180, 0));
    }
}
