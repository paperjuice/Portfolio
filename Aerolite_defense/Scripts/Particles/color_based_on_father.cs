using UnityEngine;
using System.Collections;

public class color_based_on_father : MonoBehaviour {

    public GameObject father;

    void Start()
    {
        //change color of the particles based on the father
        GetComponent<ParticleSystem>().startColor = father.GetComponent<ParticleSystem>().startColor - new Color32(0,0,0,200);
    }
}
