using UnityEngine;
using System.Collections;

public class playerBehaviour : MonoBehaviour {

    private SpriteRenderer sprite;
    private GameObject[] obstacles;
    private GameObject controller;

    //particles for when the obs gets destroyed
    public GameObject obs_part_destro;

    //sound on button press
    public GameObject sound_on_keyPress;

    //sound on meteor destro
    public GameObject sound_obs_destro;

    //get the colors 
    public GameObject q;
    public GameObject w;
    public GameObject e;
    public GameObject r;
    public GameObject t;
    public GameObject y;
    public GameObject u;
    public GameObject i;

    public int colorCode;
    public int multiplier = 1;   //combo
    public TextMesh multiplierText;

    //lives related
    public int lives = 3;
    public bool trigger_heart_shatter = false;
    public GameObject heart_shatter;
    public GameObject live_left;
    public GameObject live_mid;
    public GameObject live_right;

    //particles on color change
    public GameObject change_color_particles;

    //player's shield
    public GameObject trail;

    //atmosfera 
    public GameObject atmosphere_part;

    //after death components
    public GameObject death_part;
    public GameObject shield_1;  //enable constant force + collider off
    public GameObject shield_part; //setActive(false) 
    public GameObject planet; //collider off + sprite renderer off




    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();

        controller = GameObject.FindGameObjectWithTag("controller");
    }

    IEnumerator Start()
    {
        while (true)
        {
            obstacles = GameObject.FindGameObjectsWithTag("obstacle");
            yield return new WaitForSeconds(0.3f);
        }
    }

    void Update()
    {
        ColorChange();
        Lives();
        ActivateColors();
        Lose_Lives();
        Death();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject obstacle in obstacles)
        {
            if (col.gameObject == obstacle)
            {
                if (colorCode == obstacle.GetComponent<obsColorRoll>().colorCode)
                {
                    Destroy(obstacle.gameObject);

                    controller.GetComponent<controller>().score += obstacle.GetComponent<obsBehaviour>().pointsValue * multiplier;
                    multiplier++;
                    Instantiate(multiplierText, transform.position, transform.rotation);

                    obs_part_destro.GetComponent<ParticleSystem>().startColor = obstacle.GetComponent<SpriteRenderer>().color;
                    Instantiate(obs_part_destro, obstacle.transform.position, obs_part_destro.transform.rotation);
                    Instantiate(sound_obs_destro, obstacle.transform.position, obs_part_destro.transform.rotation);


                }
                /*else
                {
                    multiplier = 1;
                    lives--;
                    trigger_heart_shatter = true;
                }*/
            }
        }
    }

    void ColorChange()
    {
        if (Input.GetKeyDown("q"))
        {
            //sprite.color = new Color32(203, 40, 40, 255);

            //change color using the color code
            sprite.color = q.GetComponent<SpriteRenderer>().color;
            colorCode = 1;
            change_color_particles.GetComponent<ParticleSystem>().startColor = q.GetComponent<SpriteRenderer>().color ;
            atmosphere_part.GetComponent<ParticleSystem>().startColor = q.GetComponent<SpriteRenderer>().color - new Color32(0,0,0,200);
            Instantiate(sound_on_keyPress, transform.position, transform.rotation);

            if (trail != null)
                trail.GetComponent<SpriteRenderer>().color = q.GetComponent<SpriteRenderer>().color;
        }

        if (Input.GetKeyDown("w"))
        {
            //sprite.color = new Color32(218, 139, 0, 255);
            sprite.color = w.GetComponent<SpriteRenderer>().color;
            colorCode = 2;
            change_color_particles.GetComponent<ParticleSystem>().startColor = w.GetComponent<SpriteRenderer>().color ;
            atmosphere_part.GetComponent<ParticleSystem>().startColor = w.GetComponent<SpriteRenderer>().color - new Color32(0, 0, 0, 200); ;
             Instantiate(sound_on_keyPress, transform.position, transform.rotation);

            if(trail!=null)
                trail.GetComponent<SpriteRenderer>().color = w.GetComponent<SpriteRenderer>().color;
        }

        if (Input.GetKeyDown("e"))
        {
            //sprite.color = new Color32(98, 184, 0, 255);
            if (e.gameObject.activeInHierarchy == true)
            {
                sprite.color = e.GetComponent<SpriteRenderer>().color;
                colorCode = 3;
                change_color_particles.GetComponent<ParticleSystem>().startColor = e.GetComponent<SpriteRenderer>().color;
                atmosphere_part.GetComponent<ParticleSystem>().startColor = e.GetComponent<SpriteRenderer>().color - new Color32(0, 0, 0, 200); ;
                 Instantiate(sound_on_keyPress, transform.position, transform.rotation);

                if (trail != null)
                    trail.GetComponent<SpriteRenderer>().color = e.GetComponent<SpriteRenderer>().color;
            }
        }

        if (Input.GetKeyDown("r"))
        {
           // sprite.color = new Color32(16, 212, 147, 255);
            if (r.gameObject.activeInHierarchy == true)
            {
                sprite.color = r.GetComponent<SpriteRenderer>().color;
                colorCode = 4;
                change_color_particles.GetComponent<ParticleSystem>().startColor = r.GetComponent<SpriteRenderer>().color;
                atmosphere_part.GetComponent<ParticleSystem>().startColor = r.GetComponent<SpriteRenderer>().color - new Color32(0, 0, 0, 200); ;
                Instantiate(sound_on_keyPress, transform.position, transform.rotation);

                if (trail != null)
                    trail.GetComponent<SpriteRenderer>().color = r.GetComponent<SpriteRenderer>().color;
            }
        }

        if (Input.GetKeyDown("t"))
        {
            //sprite.color = new Color32(35, 107, 225, 255);
            if (t.gameObject.activeInHierarchy == true)
            {
                sprite.color = t.GetComponent<SpriteRenderer>().color;
                colorCode = 5;
                change_color_particles.GetComponent<ParticleSystem>().startColor = t.GetComponent<SpriteRenderer>().color;
                atmosphere_part.GetComponent<ParticleSystem>().startColor = t.GetComponent<SpriteRenderer>().color - new Color32(0, 0, 0, 200); ;
                 Instantiate(sound_on_keyPress, transform.position, transform.rotation);

                if (trail != null)
                    trail.GetComponent<SpriteRenderer>().color = t.GetComponent<SpriteRenderer>().color;
            }
        }

        if (Input.GetKeyDown("y"))
        {
            //sprite.color = new Color32(102, 17, 227, 255);
            if (y.gameObject.activeInHierarchy == true)
            {
                sprite.color = y.GetComponent<SpriteRenderer>().color;
                colorCode = 6;
                change_color_particles.GetComponent<ParticleSystem>().startColor = y.GetComponent<SpriteRenderer>().color;
                atmosphere_part.GetComponent<ParticleSystem>().startColor = y.GetComponent<SpriteRenderer>().color - new Color32(0, 0, 0, 200); ;
                 Instantiate(sound_on_keyPress, transform.position, transform.rotation);

                if (trail != null)
                    trail.GetComponent<SpriteRenderer>().color = y.GetComponent<SpriteRenderer>().color;
            }
        }

        if (Input.GetKeyDown("u"))
        {
           // sprite.color = new Color32(197, 19, 148, 255);
            if (u.gameObject.activeInHierarchy == true)
            {
                sprite.color = u.GetComponent<SpriteRenderer>().color;
                colorCode = 7;
                change_color_particles.GetComponent<ParticleSystem>().startColor = u.GetComponent<SpriteRenderer>().color;
                atmosphere_part.GetComponent<ParticleSystem>().startColor = u.GetComponent<SpriteRenderer>().color - new Color32(0, 0, 0, 200); ;
                 Instantiate(sound_on_keyPress, transform.position, transform.rotation);

                if (trail != null)
                    trail.GetComponent<SpriteRenderer>().color = u.GetComponent<SpriteRenderer>().color;
            }
        }

        if (Input.GetKeyDown("i"))
        {
            //sprite.color = new Color32(233, 233, 233, 255);
            if (i.gameObject.activeInHierarchy == true)
            {
                sprite.color = i.GetComponent<SpriteRenderer>().color;
                colorCode = 8;
                change_color_particles.GetComponent<ParticleSystem>().startColor = i.GetComponent<SpriteRenderer>().color;
                atmosphere_part.GetComponent<ParticleSystem>().startColor = i.GetComponent<SpriteRenderer>().color - new Color32(0, 0, 0, 200); ;
                Instantiate(sound_on_keyPress, transform.position, transform.rotation);

                if (trail != null)
                    trail.GetComponent<SpriteRenderer>().color = i.GetComponent<SpriteRenderer>().color;
            }
        }
    }

    void Lives()
    {
        if (lives == 0)
        {
           // Debug.Log("Failed");
        }
    }

    void ActivateColors()
    {
        if (controller != null)
        {
            if (controller.GetComponent<controller>().max_roll == 4)
            {
                e.gameObject.SetActive(true);
            }

            if (controller.GetComponent<controller>().max_roll == 5)
            {
                r.gameObject.SetActive(true);
            }

            if (controller.GetComponent<controller>().max_roll == 6)
            {
                t.gameObject.SetActive(true);
            }

            if (controller.GetComponent<controller>().max_roll == 7)
            {
                y.gameObject.SetActive(true);
            }

            if (controller.GetComponent<controller>().max_roll == 8)
            {
                u.gameObject.SetActive(true);
            }

            if (controller.GetComponent<controller>().max_roll == 9)
            {
                i.gameObject.SetActive(true);
            }
        }
    }

    void Lose_Lives()
    {
        if (lives == 2 && trigger_heart_shatter == true)
        {
            live_right.gameObject.SetActive(false);
            Instantiate(heart_shatter, live_right.transform.position, transform.rotation);
            trigger_heart_shatter = false;
        }

        if (lives == 1 & trigger_heart_shatter == true)
        {
            live_mid.gameObject.SetActive(false);
            Instantiate(heart_shatter, live_mid.transform.position, transform.rotation);
            trigger_heart_shatter = false;
        }

        if (lives == 0 & trigger_heart_shatter == true)
        {
            live_left.gameObject.SetActive(false);
            Instantiate(heart_shatter, live_left.transform.position, transform.rotation);
            trigger_heart_shatter = false;
        }
    }


    void Death()
    {
        if (lives == 0)
        {
            GetComponent<CircleCollider2D>().enabled = false;
            shield_1.GetComponent<ConstantForce2D>().enabled = true;
            shield_part.gameObject.SetActive(false);
            planet.GetComponent<CircleCollider2D>().enabled = false;
            planet.GetComponent<SpriteRenderer>().enabled = false;
            atmosphere_part.gameObject.SetActive(false);

            Instantiate(death_part, death_part.transform.position , transform.rotation);
            Instantiate(death_part, death_part.transform.position , transform.rotation);
            Instantiate(death_part, death_part.transform.position , transform.rotation);
            lives = -1;

        }
    }

}
