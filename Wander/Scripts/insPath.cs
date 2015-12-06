using UnityEngine;
using System.Collections;

public class insPath : MonoBehaviour {

	public GameObject path;
	
	private GameObject player;
	
	
	
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject == player)
		{
			
			Instantiate(path, transform.position += new Vector3(0f, 650f, 0f), transform.rotation);
			Destroy(gameObject);
		}
	}
}
