using UnityEngine;
using System.Collections;

public class secondaryBulletMove : MonoBehaviour {

	public GameObject bulletIns;
	public GameObject bulletDestroyParticle;
	//public GameObject bulletDestroyAudioOne;
	//public GameObject bulletDestroyAudioTwo;
	//public GameObject bulletDestroyAudioThree;
	public float speed = 3f;

	private GameObject taps;
	private GameObject[] walls;
	private GameObject[] balloons;
	private GameObject[] bullets;
	
	void Awake()
	{
		walls = GameObject.FindGameObjectsWithTag("wall");
		balloons = GameObject.FindGameObjectsWithTag("balloon");
		bullets = GameObject.FindGameObjectsWithTag("bullet");
		
		taps = GameObject.FindGameObjectWithTag("numberOfTaps");
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		foreach(GameObject wall in walls)
		{
			if(col.gameObject == wall)
			{
				Destroy(gameObject);
				Instantiate(bulletDestroyParticle, transform.position, transform.rotation);
			}
		}
		
		foreach(GameObject balloon in balloons)
		{
			if(col.gameObject == balloon)
			{
				Destroy(gameObject);
				Instantiate(bulletDestroyParticle, transform.position, transform.rotation);
				//Instantiate(bulletDestroyAudio, transform.position, transform.rotation);
			}
		}
		
		foreach(GameObject bullet in bullets)
		{
			if(col.gameObject == bullet)
			{
				Destroy(gameObject);
				Instantiate(bulletDestroyParticle, transform.position, transform.rotation);
			}
		}
	}
	
	
	
	void Update()
	{
		Move();
		InstantiateNextBullet();
	}

	void Move()
	{
		transform.position += transform.up * Time.deltaTime * speed;
	}
	
	void InstantiateNextBullet()
	{
		if(Input.GetButtonDown("Fire1") && taps.GetComponent<numberOfTaps>().numberOfTapsAvailable >0)
		{
			Destroy(gameObject);
			Instantiate(bulletIns, transform.position, transform.rotation);
			Instantiate(bulletDestroyParticle, transform.position, transform.rotation);
		}
	}
}
