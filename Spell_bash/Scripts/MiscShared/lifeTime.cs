using UnityEngine;
using System.Collections;

public class lifeTime : MonoBehaviour {

	public float lifeSpawn;

	void Start()
	{
		Destroy(gameObject, lifeSpawn);
	}
}
