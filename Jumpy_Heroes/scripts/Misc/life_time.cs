using UnityEngine;
using System.Collections;

public class life_time : MonoBehaviour {

    [SerializeField]
    private float time;

    void Start()
    {
        Destroy(gameObject, time);
    }
}
