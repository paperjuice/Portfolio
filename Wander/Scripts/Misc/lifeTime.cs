using UnityEngine;
using System.Collections;

public class lifeTime : MonoBehaviour {

	public float seconds;

	void Update()
	{
		Destroy(gameObject, seconds);
	}
}
