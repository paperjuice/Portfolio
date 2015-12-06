using UnityEngine;
using System.Collections;

public class enemy_bomb_attack : MonoBehaviour {


    private GameObject player;              //player tag
    private GameObject[] enemies;           //enemy tag             
    private float time = 0f;
    private bool explode = false;
    private Rigidbody rigid;

    private bool deal_dmg_pn_player;
    private bool deal_dmg_pn_foe;

    private bool death_on_friend;

    public GameObject enemy_body;
    public float time_till_explosion;
    public float power;
    

    public float dmg_percentage;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == player)
        {
            explode = true;
            enemy_body.GetComponent<enemy_behaviour>().ms = 0;
            deal_dmg_pn_player = true;   
        }

        if (death_on_friend == true)
        {
            foreach (GameObject enemy in enemies)
            {
                if (col.gameObject == enemy)
                {
                    //dmg on enemy
                    enemy.GetComponent<enemy_behaviour>().friendly_fire = true;
                    death_on_friend = false;
                }
            }
        }

    }

    void OnTriggerExit(Collider col)
    { 
        if(col.gameObject == player)
        {
            deal_dmg_pn_player = false;
        }
    }

    void Update()
    {
        if (explode == true)
        {
            time += Time.deltaTime;

            if (time >= time_till_explosion)
            {
                death_on_friend = true;

                player.GetComponent<Rigidbody>().AddExplosionForce(power, transform.position, 5f, 3f);
                enemy_body.GetComponent<enemy_behaviour>().health = -1;
                explode = false;
                time = 0f;

                //dmg on player
                if (deal_dmg_pn_player == true)
                {
                    player.GetComponent<hero_behaviour>().hp -= dmg_percentage/100 * player.GetComponent<hero_behaviour>().max_hp;
                    deal_dmg_pn_player = false;
                }
            }
        }
    }


}
