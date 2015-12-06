using UnityEngine;
using System.Collections;

public class multiplierText : MonoBehaviour {

    //show the combo multiplier 
    private GameObject player;

    public float ms;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {
        GetComponent<TextMesh>().text = "Combo X" + player.GetComponent<playerBehaviour>().multiplier;
    }

    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * ms;

        Color color = GetComponent<TextMesh>().color;

        color.a -= Time.deltaTime;

        GetComponent<TextMesh>().color = color;

    }

}
