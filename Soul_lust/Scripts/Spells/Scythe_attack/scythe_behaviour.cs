using UnityEngine;
using System.Collections;

public class scythe_behaviour : MonoBehaviour {


    private GameObject[] enemies;
    private float time_death;
    private float time = 0f;
    private float end_time = 1f;

    public GameObject dmg_text;
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

    /* void OnTriggerStay(Collider col)
     {
         foreach (GameObject enemy in enemies)
         {
             if (col.gameObject == enemy)
             {
                 time += Time.deltaTime;

                 if (time >= end_time)
                 {
                     dmg_text.GetComponent<TextMesh>().text = "" + dmg;
                    Instantiate(dmg_text, enemy.transform.position, transform.rotation = Quaternion.Euler(new Vector3(65f, 0, 0)));
                 }
             }
         }
     }*/


    void OnTriggerStay(Collider col)
    {
        foreach (GameObject enemy in enemies)
        {
            if (col.gameObject == enemy)
            {
                enemy.GetComponent<enemy_behaviour>().health -= dmg * Time.deltaTime;
                

                //ins text dmg
                time -= Time.deltaTime;
                if (time <=0)
                {
                    dmg_text.GetComponent<TextMesh>().text = "" + dmg;
                    Instantiate(dmg_text, enemy.transform.position, dmg_text.transform.rotation = Quaternion.Euler(new Vector3(65f, 0, 0)));
                    time = 1;
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

        if (time_death >= life_time - 0.2f)
        {
            GetComponent<BoxCollider>().center = new Vector3(0f, 100f, 0);
        }

        if (time_death >= life_time)
        {
            
            Destroy(gameObject);
        }
    }









}
