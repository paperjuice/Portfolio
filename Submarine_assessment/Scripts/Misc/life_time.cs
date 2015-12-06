using UnityEngine;
using System.Collections;

public class life_time : MonoBehaviour {

    //Ionut Vericiu


    //after a set time, the object will be destroied
    public float time;

    void Start()
    {
        Destroy(gameObject, time);
    }
}
