using UnityEngine;
using System.Collections;

public class enemyLoot : MonoBehaviour {

    private enemySts enemySts;

    public GameObject prize;



    void Awake()
    { 
        enemySts = GetComponent<enemySts>();
    }

    void Update()
    {
        if (enemySts.hp <= 0)
        {
            Debug.Log("qasd");
            Instantiate(prize, transform.position, transform.rotation);
        }
    }
}
