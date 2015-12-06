using UnityEngine;
using System.Collections;

public class hero_attack : MonoBehaviour {

    private bool attack_is_on = false;
    private float time;

    public GameObject spell;
    public string attack_button;
    public float cd;


    void Update()
    {
        if (Input.GetButtonDown(attack_button))
        {
            if (attack_is_on == false)
            {
                Instantiate(spell, transform.position, transform.rotation);
            }

            attack_is_on = true;
        }


        if (attack_is_on == true)
        {
            time += Time.deltaTime;

            if (time >= cd)
            {
                time = 0;
                attack_is_on = false;
            }
        }

    }
}
