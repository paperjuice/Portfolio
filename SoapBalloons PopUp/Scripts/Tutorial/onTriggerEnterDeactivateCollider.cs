using UnityEngine;
using System.Collections;

public class onTriggerEnterDeactivateCollider : MonoBehaviour {

	void OnTriggerEnter2D()
	{
		GetComponent<Collider2D>().enabled=false;
	}
}
