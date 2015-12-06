using UnityEngine;
using System.Collections;

public class destroyOnCollision : MonoBehaviour {

	private GameObject[] crates;
	
	void Awake()
	{
		crates = GameObject.FindGameObjectsWithTag("crate");
	}

	void OnCollisionEnter(Collision col)
	{
		foreach(GameObject crate in crates)
		{
			if(col.gameObject == crate)
			{
				Destroy(crate.gameObject);
			}
		}
	}
}	
