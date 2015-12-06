using UnityEngine;
using System.Collections;

public class randomColorOnParticles : MonoBehaviour {


    private ParticleSystem particleSystem;
    private Color col;

    void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }


    void Start()
    { 
        col =  Color.black;
    }

    

    void Update()
    {
        particleSystem.startColor = new Color(Random.value, Random.value, Random.value, 1.0f);
    }

}
