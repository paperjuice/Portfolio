using UnityEngine;
using System.Collections;

public class player_2_behaviour : MonoBehaviour {

	//Ionut Vericiu

	public KeyCode up;
	public KeyCode down;
	public float ms;		//movement speed

	//the scipt is identical with the player_1 script except the numbers that dictates where to positionate on the 3 lanes
	
	void Update()
	{
		Movement();
		Ms_augmentation ();
	}
	
	void Movement()
	{
		if (Input.GetKeyDown (down)) 
		{
			if (transform.position.y > -1.05f && transform.position.y < -0.95f) 
			{
				
				transform.position = new Vector2 (transform.position.x, -2.5f);
			}
			
			else if (transform.position.y > -2.55f && transform.position.y < -2.45f) 
			{
				transform.position = new Vector2 (transform.position.x, -4.2f);
			}
		}
		
		
		
		if (Input.GetKeyDown (up)) 
		{
			if(transform.position.y >-4.25f && transform.position.y <-4.15f)
			{
				transform.position = new Vector2(transform.position.x, -2.5f);
			}
			
			else if(transform.position.y <-2.45f && transform.position.y >-2.55f)
			{
				transform.position = new Vector2(transform.position.x, -1f);
			}
		}
		
		transform.position += Vector3.right * Time.deltaTime * ms;
	}

	void Ms_augmentation()
	{
		ms += Time.deltaTime * 0.2f;
	}

}
