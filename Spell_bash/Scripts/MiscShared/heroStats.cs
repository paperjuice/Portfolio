using UnityEngine;
using System.Collections;

public class heroStats : MonoBehaviour {

	public GameObject opposite_player_panel;

	public GameObject end_tab;

    public GameObject death_particles;
    public GameObject hpBar;
    public GameObject manaBar;
    public string bodyColor;
    public float health;
    public float mana;
    public float manaRegen;
    public string tagName;

    private GameObject camera;
    private GameObject textTag;
    private GameObject blueBody;
    private float maxMana;
    private float maxHealth;	
    private Vector3 m;
    private Vector3 h;

    
    
    void Awake()
    {
        textTag = GameObject.FindGameObjectWithTag(tagName);
        blueBody = GameObject.FindGameObjectWithTag(bodyColor);
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    
    void Start()
    {

			maxMana = mana;
			maxHealth = health;

			
    }
    
    
    void Update()
    {
        if(health<=0f)
        {
            health = 0f;
        }
        
        if(mana<=maxMana)
        {
            mana += manaRegen * Time.deltaTime;
        }
        
        //StatsText();
        ScaleHp();
        //Dead();
        Dead_v2();
    }
    
    void StatsText()
    {
        textTag.GetComponent<TextMesh>().text = "Health: " + health.ToString("N0") + "\n" +
                                                "Mana: " + mana.ToString("N0");
    }
    
    void ScaleHp()
    {
        m = manaBar.transform.localScale;
        h = hpBar.transform.localScale;
    
        h.x = health/maxHealth;
        m.x = mana/maxMana;
        
        manaBar.transform.localScale = m;
        hpBar.transform.localScale = h;
        
        
    }
    
    void Dead()			//nu o folosesc p-asta
    {
        if(health <= 0f)
        {
            health = -0.1f;
            blueBody.GetComponent<activateAnim>().dead = true;
            Time.timeScale = 0.2f;
        }
    }

    void Dead_v2()
    {
        if (health <= 0f)
        {
			opposite_player_panel.SetActive(true);
			end_tab.GetComponent<tab_activator>().activate_tab = true;
            health = -0.1f;
            Instantiate(death_particles, transform.position, transform.rotation);
            gameObject.SetActive(false);
            camera.GetComponent<Animator>().SetTrigger("death");
        }
    }

    

}
