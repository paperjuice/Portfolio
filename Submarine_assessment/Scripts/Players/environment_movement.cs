using UnityEngine;
using System.Collections;

public class environment_movement : MonoBehaviour {

	//Dragos Dumitru

	//so we have everything in the "environment" moves with the player

	private GameObject environment;

	void Awake()
	{
		environment = GameObject.FindGameObjectWithTag("ground");
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//the environment moves when the playe touches a collider set on the object
		if(col.gameObject == environment)
		{
			environment.transform.position += new Vector3(10f, 0f,0f);		
		}
	}


}
