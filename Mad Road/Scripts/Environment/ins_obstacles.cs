using UnityEngine;
using System.Collections;

public class ins_obstacles : MonoBehaviour {

    private GameObject player;
    private int random_obj;
    private int ins_ramp = 0;
    

    public GameObject ramp;
    public GameObject enemy;
    public GameObject rock_1;
    public GameObject rock_2;

    private int till_combat = 0;
    public int till_combat_max = 0;

    public int enemy_no = 1;
    public bool in_combat = false;
    public float z;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == player)
        {
            
            transform.position = new Vector3(Random.Range(-3f,3f), transform.position.y, transform.position.z + z);

            if (in_combat == false)
            {
                random_obj = Random.Range(1, 11);

                if (random_obj == 1)
                {
                    Instantiate(ramp, transform.position, ramp.transform.rotation);
                }
                else if (random_obj == 2)
                {
                    Instantiate(rock_2, transform.position, rock_2.transform.rotation *= Quaternion.AngleAxis(Random.Range(-45f, 45f), Vector3.up));
                }
                else
                {
                    Instantiate(rock_1, transform.position, rock_1.transform.rotation *= Quaternion.AngleAxis(Random.Range(0f, 180f), Vector3.up));
                }
            }


            if (in_combat == false)
            {
                till_combat++;

                if (till_combat == till_combat_max)
                {
                    in_combat = true;
                    till_combat = 0;
                }
            }



            Combat_true();
        }
    }

    void Combat_true()
    {
        if (in_combat == true)
        {
            if (enemy_no > 0)
            {
                Instantiate(enemy, enemy.transform.position = new Vector3(0, transform.position.y, transform.position.z), ramp.transform.rotation);
                enemy_no--;
            }


            ins_ramp++;

            if (ins_ramp == 3)
            {
                Instantiate(ramp, transform.position, ramp.transform.rotation);
                ins_ramp = 0;
            }
        }
    }


}
