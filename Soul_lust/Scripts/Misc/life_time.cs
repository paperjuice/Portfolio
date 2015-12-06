using UnityEngine;
using System.Collections;

public class life_time : MonoBehaviour {

    public float lifeTime;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
