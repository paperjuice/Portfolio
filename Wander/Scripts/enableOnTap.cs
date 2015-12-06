using UnityEngine;
using System.Collections;

public class enableOnTap : MonoBehaviour {

	private GameObject player;
	private GameObject obs;
	private GameObject tut;
	
	
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		obs = GameObject.FindGameObjectWithTag("obstacle");
		tut = GameObject.FindGameObjectWithTag("tutorial");
	}
	
	
	
	void Update()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			player.GetComponent<movement>().enabled = true;
			obs.GetComponent<insObstacles>().enabled = true;
			tut.GetComponent<fadeInText>().enabled = true;
			tut.GetComponent<lifeTime>().enabled = true;
			
			Destroy(gameObject);
		}
	}

}
