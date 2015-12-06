using UnityEngine;
using System.Collections;

public class acidDmgOnPlayer : MonoBehaviour {

	public GameObject blood;
	public bool dealDmg;
	public GameObject hero;
	public float dmg;
	
	void Update()
	{
		if(dealDmg == true)
		{
			hero.GetComponent<heroStats>().health -= Time.deltaTime * dmg;
			Instantiate(blood, transform.position, transform.rotation);
		}
		
	}
}
