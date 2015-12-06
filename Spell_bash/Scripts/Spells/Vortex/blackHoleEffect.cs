using UnityEngine;
using System.Collections;

public class blackHoleEffect : MonoBehaviour {

	private GameObject[] heroes;
	private GameObject[] props;
	
	public float pullForce;
	
	void Awake()
	{
		heroes = GameObject.FindGameObjectsWithTag("Player");
		props = GameObject.FindGameObjectsWithTag("prop");
	}
	
	void OnTriggerStay(Collider col)
	{
		foreach(GameObject hero in heroes)
		{
			if(col.gameObject == hero)
			{
				hero.GetComponent<Rigidbody>().AddForce((hero.transform.position - transform.position) * -pullForce * Time.fixedDeltaTime);
				//hero.GetComponent<Rigidbody>()
				//hero.GetComponent<Rigidbody>().velocity = (hero.transform.position - transform.position) * -pullForce ;
			}
		}
		
		foreach(GameObject prop in props)
		{
			if(col.gameObject == prop)
			{
				if(prop.GetComponent<Rigidbody>()!=null)
				prop.GetComponent<Rigidbody>().AddForce((prop.transform.position - transform.position) * -pullForce*1.5f * Time.deltaTime);
			}
		}
	}
}
