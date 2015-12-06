using UnityEngine;
using System.Collections;

public class pointer_v2 : MonoBehaviour {

    private GameObject[] pies;
    private float random_speed;
    private float time;
    //amount of time it spins
    private float end_time = 4f;
    private bool start_countdown;
    private bool times_up;
    private Animator anim;

    //sound start
   // [SerializeField]
    private bool start_spin_sound;
    private float time_sound;   //pauses between spin sounds
    private float end_time_sound = 0.05f;
    
    //win amount in text;
    public GameObject text_win_ammount;

    public GameObject spin_sound;
    public GameObject wheel;
    public bool start_spin;


    void Awake()
    {
        anim = GetComponent<Animator>();
        pies = GameObject.FindGameObjectsWithTag("pie");
    }

    void Update()
    {
        Rotate();
        Countdown();
        Start_spin_sound();
    }

    void Rotate()
    {
        if (start_spin == true)
        {
            start_spin_sound = true;
            random_speed = Random.Range(500f, 600f);
            time = 0f; 
            start_spin = false;
            start_countdown = true;
            anim.SetBool("move", true);
            anim.speed = 1;
        }

        if (random_speed >= 1)
        {
            random_speed -= Time.deltaTime * 99f;
            anim.speed -= Time.deltaTime * 0.2f;
            wheel.transform.Rotate(Vector3.forward * Time.deltaTime * -random_speed);
            
        }
    }

    void Countdown()
    {
        if (start_countdown == true)
        {
            time += Time.deltaTime;

            if (time >= end_time)
            {
                times_up = true;
                start_countdown = false;
                GetComponent<CircleCollider2D>().enabled = true;
                time = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (times_up == true)
        {
            foreach (GameObject pie in pies)
            {
                if (col.gameObject == pie)
                {
                    start_spin_sound = false;
                    end_time_sound = 0.05f;
                    random_speed = 0;
                    GetComponent<CircleCollider2D>().enabled = false;
                    //the amount you have won
                    money.money_amount += pie.GetComponent<pie_piece>().prize;
                    anim.speed = 0f;
                    anim.SetBool("move", false);
                    PlayerPrefs.SetFloat("money", money.money_amount);
                    text_win_ammount.GetComponent<TextMesh>().text = "" + pie.GetComponent<pie_piece>().prize + "$$";
                    Instantiate(text_win_ammount, text_win_ammount.transform.position = new Vector2(0f,-1f), text_win_ammount.transform.rotation);
                }
            }
        }
    }

    void Start_spin_sound()
    {
        if (start_spin_sound == true)
        {
            if (time_sound <= 0)
            {
                Instantiate(spin_sound, transform.position, transform.rotation);
               
            }
            time_sound += Time.deltaTime;
            if (time_sound >= end_time_sound)
            {
                time_sound = 0f;
                end_time_sound += 0.01f;
            }
        }
    }
}
