using UnityEngine;
using System.Collections;

public class rotateTornado : MonoBehaviour {

	public float speed;

	void Update()
	{
		transform.Rotate(Vector3.up  * speed);
	}
}
