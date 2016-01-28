using UnityEngine;
using System.Collections;

public class obs_behaviour : MonoBehaviour {

	public GameObject death_part;
	public GameObject player_death_part;
    public float ms;


	private GameObject player;
	private GameObject ground;
	private GameObject camera_;
    private GameObject obs_ins;


    void Awake()
    {
		player = GameObject.FindGameObjectWithTag("Player");
		camera_ = GameObject.FindGameObjectWithTag("MainCamera");
        ground = GameObject.FindGameObjectWithTag("ground");
		obs_ins = GameObject.FindGameObjectWithTag("obs_ins");
    }
    void Start()
    {
		ms = obs_ins.GetComponent<obs_ins>().ms;
    }


    void Update()
    {
        transform.position += Vector3.up * -ms * Time.deltaTime; 
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
			Instantiate (player_death_part, transform.position, transform.rotation);
            camera_.GetComponent<Animator>().SetTrigger("shake");
            
            Destroy(player.gameObject);

        }

		if (col.gameObject == ground)
		{
            Instantiate(death_part, death_part.transform.position = new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z), transform.rotation);
            if (player != null)
            {
                score.score_++;
            }
			Destroy(gameObject);

		}

    }
}
