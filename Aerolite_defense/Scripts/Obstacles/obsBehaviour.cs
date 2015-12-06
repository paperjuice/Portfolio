using UnityEngine;
using System.Collections;

public class obsBehaviour : MonoBehaviour {

    private GameObject controller;
    private GameObject target;
    private float rs;

    public float ms;
    public int pointsValue;

    void Awake()
    {
        controller = GameObject.FindGameObjectWithTag("controller");
        target = GameObject.FindGameObjectWithTag("target");
    }

    void Start()
    {
        transform.localScale = new Vector3(Random.Range(0.03f, 0.07f), Random.Range(0.03f, 0.07f), 0.13f);

        ms = controller.GetComponent<controller>().ms;
        rs = Random.Range(-10f, 10f);
    }

    void Update()
    {
        Rotate();
       // Rotate_v2();
    }

    void FixedUpdate()
    { 
        Movement();
    }

    void Movement()
    {
        transform.position -= Vector3.up * ms * Time.fixedDeltaTime;
    }

    void Rotate()
    {
        transform.Rotate(Vector3.forward * rs);
    }

    void Rotate_v2()
    {
        transform.LookAt(target.transform.position);

       // transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }
}
