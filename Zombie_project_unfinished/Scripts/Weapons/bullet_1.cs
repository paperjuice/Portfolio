using UnityEngine;
using System.Collections;

public class bullet_1 : MonoBehaviour {


    public GameObject zombieBlood;
    public float ms;
    public float dmg;

    private GameObject[] enemies;




    void Awake()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

   


    void FixedUpdate()
    {
        Movement();
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                Debug.Log("enemy hit");
                Instantiate(zombieBlood, transform.position, transform.rotation);
                Destroy(gameObject);
                enemy.GetComponent<generalEnemyStats>().hp -= dmg;
            }

        }
    }

    void Movement()
    {
        transform.position += transform.right * ms * Time.fixedDeltaTime;
    }
}
