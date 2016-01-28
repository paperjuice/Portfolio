using UnityEngine;
using System.Collections;

public class player_behaviour : MonoBehaviour {

    private GameObject[] walls;
    private Rigidbody2D rigid;
    private GameObject text;
    private GameObject death;
    private GameObject tutorial;

    float time = 0.5f;
    private int direction = 1;
    private bool can_jump = false;

    public GameObject death_part;
    public GameObject death_sound;

    public GameObject jump_sound_true;
    public GameObject jump_sound_false;
    public GameObject spikes;
    public float jp = 20;
    private int score = 0;
    public static int high_score;


    void Awake()
    {
        high_score = PlayerPrefs.GetInt("high_score");

        rigid = GetComponent<Rigidbody2D>();
        text = GameObject.FindGameObjectWithTag("text");
        tutorial = GameObject.FindGameObjectWithTag("tutorial");
        
    }

    IEnumerator Start()
    {
        while (true)
        {
            walls = GameObject.FindGameObjectsWithTag("wall");

            yield return new WaitForSeconds(0.1f);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        foreach (GameObject wall in walls)
        {
            if (col.gameObject == wall)
            {

                can_jump = true;
                //rigid.AddForce(Vector2.right * -direction * 200);
                if (Input.GetKey("l"))
                {
                    Auto_jump();
                }
            }
        }

        if (col.gameObject == death)
        {
            Instantiate(death_sound, transform.position, transform.rotation);
            Instantiate(death_part, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        foreach (GameObject wall in walls)
        {
            if (col.gameObject == wall)
            {
                can_jump = false;
            }
        }
    }

    void Update()
    {
        Jump_up();
        Show_score();
        Spike_appear();
    }

    void Jump_up()
    {
        if (can_jump == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(jump_sound_true, transform.position, transform.rotation);
                //rigid.AddForce(new Vector2(direction, 1) * jp);
                rigid.velocity = ((Vector2.right * direction) + Vector2.up) * jp;
                direction *= -1;
                score++;
                can_jump = false;
            }
        }
        else if (can_jump == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(jump_sound_false, transform.position, transform.rotation);
            }
        }
    }

    void Show_score()
    {
        text.GetComponent<TextMesh>().text = score.ToString("N0") + "\nHighScore: " + high_score.ToString("N0");

        if (score > high_score)
        {
            high_score = score;
            PlayerPrefs.SetInt("high_score", high_score);
        }
    }

    void Spike_appear()
    {
        if (score >= 1)
        {
            if (tutorial != null)
            {
                tutorial.gameObject.SetActive(false);
            }

            time -= Time.deltaTime;
            if(time <=0f)
            {
                death = GameObject.FindGameObjectWithTag("death");
                spikes.gameObject.SetActive(true);
            }
        }
    }

    void Auto_jump()
    {
        rigid.velocity = ((Vector2.right * direction) + Vector2.up) * jp;
        direction *= -1;
        score++;
    }

}
