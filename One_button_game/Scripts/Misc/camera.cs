using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {


	private GameObject player;

	public float xCustom;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Start()
	{
		transform.position = new Vector3(6.9f, -0.8f, -10f);
	}
	
	void LateUpdate()
	{
		transform.position = new Vector3(player.transform.position.x + xCustom, transform.position.y , transform.position.z);
	}

}
