using UnityEngine;
using System.Collections;

public class random_colour : MonoBehaviour {

    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(Random.value, Random.value, Random.value, 1);
    }
}
