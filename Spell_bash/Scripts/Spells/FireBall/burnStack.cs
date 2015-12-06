using UnityEngine;
using System.Collections;

public class burnStack : MonoBehaviour {

	private GameObject red;
	private GameObject blue;
	private bool redPos;
	private bool bluePos;
	
	private GameObject[] heroes;
	private Vector3 heroPos;
	private bool pos;
	
/*	
	void Awake()
	{
		heroes = GameObject.FindGameObjectsWithTag("Player");
	}
	
	void OnCollisionEnter(Collision col)
	{
		foreach(GameObject hero in heroes)
		{
			if(col.gameObject == hero)
			{
				pos = true;
			}
		}	
	}*/
	
	/*void Update()
	{
		if(pos == true)
		{
			transform.position = new Vector3(hero.transform.position.x, hero.transform.position.y +1f, hero.transform.position.z);
		}
	}*/
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	void Awake()
	{
		red = GameObject.FindGameObjectWithTag("red");
		blue = GameObject.FindGameObjectWithTag("blue");
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject == red)
		{
			redPos = true;
		}
		
		if(col.gameObject == blue)
		{
			bluePos = true;
		}
	}
	
	void Update()
	{
		if(redPos == true)
		{
			transform.position = new Vector3(red.transform.position.x, red.transform.position.y +1f, red.transform.position.z);
			GetComponent<BoxCollider>().enabled = false;
		}
		
		if(bluePos == true)
		{
			transform.position = new Vector3(blue.transform.position.x, blue.transform.position.y +1f, blue.transform.position.z);
			GetComponent<BoxCollider>().enabled = false;
		}
	}
	
	
	
	
	
	
}
