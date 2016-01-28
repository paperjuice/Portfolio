using UnityEngine;
using System.Collections;

public class pillar_dmg : MonoBehaviour
{
    private GameObject player;


    public float dmg;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject == player)
        {
            player.GetComponent<hero_behaviour>().hp -= player.GetComponent<hero_behaviour>().hp / 100 * dmg;
        }
    }

    
}
