using UnityEngine;
using System.Collections;

public class wallOfDeathBehaviour : MonoBehaviour {

	private GameObject[] heroes;
	
	public float power;
	
	void Awake()
	{
		heroes = GameObject.FindGameObjectsWithTag("Player");
	}
	
	void Start()
	{
		GetComponent<Rigidbody>().AddForce(transform.forward * power * 1000);
	}
	
	void OnTriggerEnter(Collider col)
	{
		foreach(GameObject hero in heroes)
		{
			if(col.gameObject == hero)
			{
				hero.GetComponent<wallOfDeathOnPlayer>().wallOfDeathStacks ++;
				Debug.Log("asd");
			}
		}
	}
}
