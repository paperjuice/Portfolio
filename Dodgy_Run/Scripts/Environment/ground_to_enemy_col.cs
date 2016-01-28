using UnityEngine;
using System.Collections;

public class ground_to_enemy_col : MonoBehaviour {

    private GameObject[] enemies;
    private GameObject player;

    public GameObject enemy_death_particle;
    public GameObject enemy_2_death_particle;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    IEnumerator Start()
    {
        while (true)
        {
            enemies = GameObject.FindGameObjectsWithTag("enemy");

            yield return new WaitForSeconds(0.1f);
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                if (player != null)
                {
                    score.score_++;
                }

                /*if (score.score_ <= 14)
                {
                    Instantiate(enemy_death_particle, enemy.transform.position = new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.2f, enemy.transform.position.z), transform.rotation);
                }
                else if(score.score_ > 14)
                {
                    Instantiate(enemy_2_death_particle, enemy.transform.position = new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.2f, enemy.transform.position.z), transform.rotation);
                }*/

                Destroy(enemy.gameObject);
            }
        }
    }
}
