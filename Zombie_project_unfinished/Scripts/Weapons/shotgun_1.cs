using UnityEngine;
using System.Collections;

public class shotgun_1 : MonoBehaviour {


    private GameObject[] enemies; 
    private Animator anim;
    private float time;
    private bool onCd;


    public GameObject projectile;
    public float cd;



    void Awake()
    {
        anim = GetComponent<Animator>();

        enemies = GameObject.FindGameObjectsWithTag("enemy");
    }

    void Update()
    {
        Animation();
        WeaponCooldown();
    }

    void Animation()
    {
        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            anim.SetBool("move", true);
        }
        else
        {
            anim.SetBool("move", false);
        }
    }

    void WeaponCooldown()
    { 
        if(Input.GetKeyDown("k"))
        {
            //cand se trigaruieste sar proiectilele
            if (onCd == false)
            {
                Instantiate(projectile, transform.position +=  transform.right *1.7f + new Vector3(0f,0.7f, 0f), transform.rotation);
                anim.SetTrigger("shoot");
                onCd = true;
            }
        }

        if (onCd == true)
        {
            time += Time.deltaTime;
            if(time>=cd)
            {
                onCd = false;
                time = 0f;
            }

        }

    }



}
