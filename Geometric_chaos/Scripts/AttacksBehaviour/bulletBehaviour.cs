using UnityEngine;
using System.Collections;

public class bulletBehaviour : MonoBehaviour {

    private GameObject[] enemies;
    private Rigidbody2D rigid;

    public float attractionPower;
    public float ms;
    public float dmg;

    void Awake()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        rigid = GetComponent<Rigidbody2D>();
    }


    IEnumerator Start()
    {
        while (true)
        {
            enemies = GameObject.FindGameObjectsWithTag("enemy");

            yield return new WaitForSeconds(0.2f); 
        }
    }


    void FixedUpdate()
    {
        Move();
       // AttractedByEnemy();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                enemy.GetComponent<enemySts>().hp -= dmg;
            }
        }
    }



    void Move()
    { 
        transform.position += transform.up * ms * Time.fixedDeltaTime;
    }

    void AttractedByEnemy()
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                if (Vector3.Distance(transform.position, enemy.transform.position) < 10)
                {
                  //  rigid.AddForce((enemy.transform.position - transform.position) * attractionPower);
                    transform.Rotate((-enemy.transform.position - transform.position) * attractionPower * Time.deltaTime);
                }
            }
        }
    }
}
