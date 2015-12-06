using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {

	private GameObject[] respawnPlatforms;
	
	public float damage;
	
	void Awake()
	{
		respawnPlatforms = GameObject.FindGameObjectsWithTag("respawn");
	}
	
	
	
	void OnCollisionEnter(Collision col)
	{
		foreach(GameObject respawnPlatform in respawnPlatforms)
		{
			if(col.gameObject == respawnPlatform)
			{
				transform.position = new Vector3(Random.Range(-22f,22f), 10f, Random.Range(-9f,9f));
				GetComponent<heroStats>().health -=damage;
			}
		}
	}
}
