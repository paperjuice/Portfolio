using UnityEngine;
using System.Collections;

public class vortex_behaviour : MonoBehaviour {

    private GameObject[] enemies;
    private float time;


    public float end_time;
    public float rs;


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
        Pull_();
        Time_On();
        Rotate();
    }

    void Pull_()
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                if (Vector3.Distance(transform.position, enemy.transform.position) < 10f)
                {
                    // Vector3 target = enemy.transform.position;
                    //enemy.transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, Time.deltaTime * 0.5f);


                    enemy.transform.position = Vector3.Lerp(enemy.transform.position, transform.position, Time.deltaTime * 3f);
                    enemy.GetComponent<enemy_behaviour>().ms = 0;
                }
                
            }
        }
    }

    void Time_On()
    {
        time += Time.deltaTime;

        if (time >= end_time)
        {
            Destroy(gameObject);
        }
    }

    void Rotate()
    {
        transform.Rotate(Vector3.up * rs * Time.deltaTime);
        transform.Rotate(Vector3.right * rs * Time.deltaTime);
    }
}
