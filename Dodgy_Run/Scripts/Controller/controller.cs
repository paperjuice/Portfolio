using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {

    private float time = 0f;



    private GameObject[] enemies;

    public bool start;
    public GameObject enemy_1;
    public GameObject enemy_2;
    public GameObject enemy_3;
    public float ms;
    public float end_time;

    IEnumerator Start()
    {
        while (true)
        {
            enemies = GameObject.FindGameObjectsWithTag("enemy");

            yield return new WaitForSeconds(0.1f);
        }
    }

    void Update()
    {
        if (start == true)
        {
            Movement();
            Ins_enemies();
        }
    }

    void Movement()
    {
        if (ms <= 10)
        {
            ms += Time.deltaTime * 0.15f;
        }

        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.transform.position += Time.deltaTime * Vector3.up * -ms;
            }
        }
    }

    void Ins_enemies()
    {
        if (end_time >= 0.35f)
        {
            end_time -= Time.deltaTime *0.03f;
        }

        time += Time.deltaTime;

        if (time >= end_time)
        {
            transform.position = new Vector2(Random.Range(-2.3f, 2.3f), transform.position.y);

            if (score.score_ <= 30)
            {
                Instantiate(enemy_1, transform.position, transform.rotation);
            }
            else if (score.score_ > 35 && score.score_ <= 80)
            {
                Instantiate(enemy_2, transform.position, transform.rotation);
            }
            else if (score.score_ > 80 )
            {
                Instantiate(enemy_3, transform.position, transform.rotation);
            }

                time = 0f;
        }    
    }

}
