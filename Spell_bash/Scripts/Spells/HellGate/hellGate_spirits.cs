using UnityEngine;
using System.Collections;

public class hellGate_spirits : MonoBehaviour {

	private GameObject red;
	private GameObject blue;
	private GameObject[] players;
	
	public string whoTofollow;
	public float dmg;
	public float ms;
	
	void Awake()
	{
		red = GameObject.FindGameObjectWithTag("red");
		blue = GameObject.FindGameObjectWithTag("blue");
		players = GameObject.FindGameObjectsWithTag("Player");
	}
	
	void OnCollisionEnter(Collision col)
	{
		foreach(GameObject player in players)
		{
			if(col.gameObject == player)
			{
				player.GetComponent<heroStats>().health -= dmg;
				Destroy(gameObject);
			}
		}
	}
	
	
	void FixedUpdate()
	{
		WhoToFollow();
	}
	
	void WhoToFollow()
	{
		if(whoTofollow == "red")
		{
			transform.position = Vector3.MoveTowards(transform.position, red.transform.position, ms * Time.deltaTime);
		}
		
		if(whoTofollow == "blue")
		{
			transform.position = Vector3.MoveTowards(transform.position, blue.transform.position, ms * Time.deltaTime);
		}
	}
	
	
	
	
	
}
