using UnityEngine;
using System.Collections;

public class playerSts : MonoBehaviour {

    private int maxHealth;

    public GameObject soundDestro;
    public GameObject destroPart;
    public GameObject healthBar;
    public float time;    //time between health drain
    public int health;


    void Awake()
    {
        maxHealth = health;
    }

    IEnumerator Start()
    {
        while (health > 0)
        {
            health--;

            yield return new WaitForSeconds(time);
        }
    }

    void Update()
    {
        Death();
        HealthBar();
    }

    void Death()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            health = 0;
            Instantiate(destroPart, transform.position, transform.rotation);
            Instantiate(soundDestro, transform.position, transform.rotation);
        }
    }

    void HealthBar()
    {
        healthBar.transform.localScale = new Vector3(((float)health / (float)maxHealth), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
    
}
