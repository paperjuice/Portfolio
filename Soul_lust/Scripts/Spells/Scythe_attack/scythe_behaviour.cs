using UnityEngine;
using System.Collections;

public class scythe_behaviour : MonoBehaviour {


    private GameObject[] enemies;
    private float time_death;
    private float time = 0f;
    private float end_time = 1f;

    public float rs;
    public float slow_power;
    public float dmg;
    public float life_time;


    IEnumerator Start()
    {
        while (true)
        {
            enemies = GameObject.FindGameObjectsWithTag("enemy");
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(life_time);
        Destroy_spell();
    }

    void Update()
    {
        Rotate();
        Destroy_spell();
    }

    void OnTriggerEnter(Collider col)
    {
        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                enemy.GetComponent<enemy_behaviour>().ms = enemy.GetComponent<enemy_behaviour>().ms / slow_power;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                enemy.GetComponent<enemy_behaviour>().ms = enemy.GetComponent<enemy_behaviour>().starting_ms;
            }
        }
    }

    void OnTriggerStay(Collider col)
    {
        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                time += Time.deltaTime;

                if (time >= end_time)
                {
                    enemy.GetComponent<enemy_behaviour>().health -= dmg;
                    time = 0;
                }
            }
        }
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rs);
    }

    void Destroy_spell()
    {
        time_death += Time.deltaTime;

        if (time_death >= life_time)
        {
            GetComponent<BoxCollider>().center = new Vector3(0f, 100f, 0);
            Destroy(gameObject);
        }
    }









}
