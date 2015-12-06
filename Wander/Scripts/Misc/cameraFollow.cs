using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

	private GameObject ship;
	public float select;
	
	void Awake()
	{
		ship = GameObject.FindGameObjectWithTag("Player");
	}


	void LateUpdate()
	{
		transform.position = new Vector3(ship.transform.position.x, ship.transform.position.y + select, transform.position.z);
	}
}
