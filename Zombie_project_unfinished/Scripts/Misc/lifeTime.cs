using UnityEngine;
using System.Collections;

public class lifeTime : MonoBehaviour {

	public float time;


	void Start()
	{
		Destroy(gameObject, time);
	}
}
