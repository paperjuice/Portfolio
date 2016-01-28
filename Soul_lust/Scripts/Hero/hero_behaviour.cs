using UnityEngine;
using System.Collections;

public class hero_behaviour : MonoBehaviour {


    //currency incrementation
    [SerializeField]
    public static float currency = 0;

    public GameObject health_text_numbers;
    public GameObject health_bar;

    public float hp;
    public float max_hp;

    public float hunger;            // cat dmg iti iei pe secunda


    void Awake()
    {
        max_hp = hp;
    }

    void Update()
    {
        Hunger_dmg();
        Health_bar_scale();
        Cap_hp();
        Death();
        Text_health();

       // print(currency);
    }


    //dmg per second
    void Hunger_dmg()
    {
        hp -= Time.deltaTime * (hunger/100 * max_hp);
    }

    void Health_bar_scale()
    {
        health_bar.transform.localScale = new Vector3(hp / max_hp, 1f, 1f);
    }

    void Death()
    {
        if (hp <= 0)
        {
            hp = 0;
            Destroy(gameObject);
            
        }
    }

    //hp wont excede the max hp
    void Cap_hp()
    {
        if (hp >= max_hp)
        {
            hp = max_hp;
        }
    }

    void Text_health()
    {
        health_text_numbers.GetComponent<TextMesh>().text = hp.ToString("N0") + "/" + max_hp; 
    }
}
