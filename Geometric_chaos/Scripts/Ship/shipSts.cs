using UnityEngine;
using System.Collections;

public class shipSts : MonoBehaviour {


    public GameObject hpPNG;
    public GameObject xpBar;
    public GameObject deathParticles;

    //stats
    public int level;
    public float currentXp;
    public float maxXp;
    public float hp;

    //upgrade
    public float hpUpgrade;



    private float maxHp;
    private SpriteRenderer spriteRend;
    private GameObject camera;


    void Awake()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        spriteRend = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        maxHp = hp;
    }


    void Update()
    {
        Death();
        HpScale();
        LevelUp();
        XpBar();
    }

    void Death()
    {
        if (hp <= 0f)
        {
            Destroy(gameObject);
            Instantiate(deathParticles, transform.position, transform.rotation);
            camera.GetComponent<Animator>().SetTrigger("shake");
        }
    }

    void HpScale()
    {
        if (hpPNG != null)
        {
            hpPNG.transform.localScale = new Vector2(hp / maxHp, 1f);
        }
    }


    void LevelUp()
    {
        if (currentXp >= maxXp)
        {
            level++;
            maxHp += hpUpgrade;
            currentXp = 0f;
            maxXp += maxXp * 0.1f;
            //spriteRend.color = new Color(Random.value + 0.5f, Random.value + 0.5f, Random.value+0.5f, 0.5f);
        }
    }

    void XpBar()
    {
        if (xpBar != null)
        {
            xpBar.transform.localScale = new Vector3(currentXp / maxXp, 1f, 1f);
        }
    }

}
