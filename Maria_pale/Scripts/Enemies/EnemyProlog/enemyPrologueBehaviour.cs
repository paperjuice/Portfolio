using UnityEngine;
using System.Collections;

public class enemyPrologueBehaviour : MonoBehaviour
{

    private GameObject player;
    private Animator anim;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            anim.SetTrigger("look");
        }
    }
}