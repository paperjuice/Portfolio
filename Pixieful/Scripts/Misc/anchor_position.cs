using UnityEngine;
using System.Collections;

public class anchor_position : MonoBehaviour {

    private GameObject anchor;

    void Awake()
    {
        anchor = GameObject.FindGameObjectWithTag("anchor");
    }

    void Update()
    {
        transform.position = new Vector2(anchor.transform.position.x, anchor.transform.position.y);
    }
}
