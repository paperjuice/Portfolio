using UnityEngine;
using System.Collections;

public class moveUp : MonoBehaviour {

	public float speed;
	
	void Update () 
	{
		transform.position += transform.up * Time.deltaTime * speed; 
	}
}
