using UnityEngine;
using System.Collections;

public class stunEffect : MonoBehaviour {

	private GameObject[] heroes;
	private float timer;

	public float stunDuration;
	public float distanceOfIns;
	
	void Awake()
	{
		heroes = GameObject.FindGameObjectsWithTag("Player");
	}

	void Start()
	{
		transform.position += transform.forward*distanceOfIns;
	}
	
	void OnTriggerEnter(Collider col)
	{
		foreach(GameObject hero in heroes)
		{
			if(col.gameObject == hero)
			{
				hero.GetComponent<heroMovement>().enabled=false;
				//hero.GetComponent<Rigidbody>().velocity=0 * Vector3.up;
				hero.GetComponent<heroStats>().mana = 0;
			}
		}
	}
	
	void FixedUpdate()
	{
		foreach(GameObject hero in heroes)
		{
			if(hero.GetComponent<heroMovement>().enabled==false)
			{
				timer += Time.deltaTime;
				if(timer>=stunDuration)
				{
					hero.GetComponent<heroMovement>().enabled=true;
					
					timer =0f;
				}
			}
		}
	}
}
