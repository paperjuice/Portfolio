using UnityEngine;
using System.Collections;

public class bulletMove : MonoBehaviour {

	public GameObject bullet;
	public GameObject bulletDestroyParticle;
	public float speed;
	
	//public GameObject bulletDestroyAudioOne;
	//public GameObject bulletDestroyAudioTwo;
	//public GameObject bulletDestroyAudioThree;
	
	private int stance= 0;
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
			
				//Instantiate(bulletDestroyAudioOne, transform.position, transform.rotation);
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
				
				//Instantiate(bulletDestroyAudioOne, transform.position, transform.rotation);
			}
		}
	}
	
	
	void Update()
	{
		Move();
		ChangeStance();
		InstantiateNextBullet();
	}
	
	void Move()
	{
		if(stance>=1)
		{
			transform.position += transform.up * Time.deltaTime * speed;
		
		}
	}
	
	void ChangeStance()
	{
		if(Input.GetButtonDown("Fire1") && taps.GetComponent<numberOfTaps>().numberOfTapsAvailable >0 )
		{
			stance++;
		}
	}
	
	void InstantiateNextBullet()
	{
		if(stance>=2)
		{
			Destroy(gameObject);
			Instantiate(bullet, transform.position, transform.rotation);
			Instantiate(bulletDestroyParticle, transform.position, transform.rotation);
			
			//Instantiate(bulletDestroyAudioOne, transform.position, transform.rotation);
		}
	}
	
	
	
	
}
