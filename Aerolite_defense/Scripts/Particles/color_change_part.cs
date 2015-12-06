using UnityEngine;
using System.Collections;

public class color_change_part : MonoBehaviour {

    private GameObject player;
    private ParticleSystem part;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        part = GetComponent<ParticleSystem>();
        
    }

  
}
