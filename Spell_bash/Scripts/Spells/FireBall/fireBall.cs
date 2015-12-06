using UnityEngine;
using System.Collections;

public class fireBall : MonoBehaviour {



	public GameObject explosion;
	public GameObject blood;
	public GameObject sound;
	public GameObject dmgText;
	public float ms;
	public float dmg;
	
	
	private GameObject cameraMain;
	private GameObject[] heroes;

	private GameObject red_tag;
	private GameObject blue_tag;

	private GameObject[] projectiles;
	
	
	
	void Awake()
	{
		cameraMain = GameObject.FindGameObjectWithTag("MainCamera");
		
		heroes  = GameObject.FindGameObjectsWithTag("Player");
		projectiles  = GameObject.FindGameObjectsWithTag("prop");

		red_tag = GameObject.FindGameObjectWithTag("red");
		blue_tag = GameObject.FindGameObjectWithTag("blue");
	}
	
	void FixedUpdate()
	{
		Move();
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject == red_tag)
		{
			red_tag.GetComponent<for_bar_dmg_part>().activate = true;
		}

		if (col.gameObject == blue_tag)
		{
			blue_tag.GetComponent<for_bar_dmg_part>().activate = true;
		}
	}



	void OnCollisionEnter(Collision col)
	{
		foreach(GameObject hero in heroes)
		{
			if(col.gameObject == hero)
			{
				hero.GetComponent<fireBallDot>().time = 0;
				hero.GetComponent<fireBallDot>().dotStack += 1;
				hero.GetComponent<fireBallDot>().applyOneBurn = true;
				hero.GetComponent<heroStats>().health -= dmg;
				cameraMain.GetComponent<Animator>().SetTrigger("shake");
				
				Destroy(gameObject);
				Instantiate(explosion, transform.position, transform.rotation);
				Instantiate(blood, transform.position, transform.rotation);
				Instantiate(sound, transform.position, transform.rotation *= Quaternion.AngleAxis(270f, Vector3.right));
				DmgTextDone();
				Instantiate(dmgText, transform.position, transform.rotation);
			}
		}
		
		foreach(GameObject projectile in projectiles)
		{
			if(col.gameObject == projectile)
			{
				Destroy(gameObject);
				Instantiate(explosion, transform.position, transform.rotation);
				Instantiate(sound, transform.position, transform.rotation *= Quaternion.AngleAxis(270f, Vector3.right));
			}
		}
	}
	
	void Move()
	{
		transform.position += transform.forward * ms * Time.deltaTime;
	}
	
	void DmgTextDone()
	{
		dmgText.GetComponent<TextMesh>().text = dmg.ToString("N0");
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
