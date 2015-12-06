using UnityEngine;
using System.Collections;

public class rotateRestartButton : MonoBehaviour {


//i used fixed deltaTime because I had to work on time scale without affecting some of the 
//objects 


	public float speed = 2f;
	
	void Update()
	{
		transform.Rotate(transform.forward, speed * Time.fixedDeltaTime);
	}
}
