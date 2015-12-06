using UnityEngine;
using System.Collections;

public class balloonMove : MonoBehaviour {


	public float speed = 10f;
	
	private float h;

	void Awake()
	{
		h = Random.Range(-0.5f,1f);
	}
	
	void Update()
	{
		
		transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
		transform.Rotate(Vector3.forward, h);
	}

	
}
