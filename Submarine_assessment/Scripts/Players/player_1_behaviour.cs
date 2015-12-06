using UnityEngine;
using System.Collections;

public class player_1_behaviour : MonoBehaviour {


	//Ionut Vericiu

	public KeyCode up;			//custom key for up
	public KeyCode down;		//custom key for down
	public float ms;			//movement speed


	void Update()
	{
		Movement();
		Ms_augmentation ();
	}

	void Movement()
	{

		//move position on 3 different lanes when down button is pressed
		if (Input.GetKeyDown (down)) 
		{
			if (transform.position.y < 4.21f && transform.position.y > 4.18f) 
			{

				transform.position = new Vector2 (transform.position.x, 2.5f);
			}
		
			else if (transform.position.y < 2.55f && transform.position.y > 2.45f) 
			{
			transform.position = new Vector2 (transform.position.x, 1f);
		}

	}



		if (Input.GetKeyDown (up)) 
		{
			if(transform.position.y >0.95f && transform.position.y <=1.05f)
			{
				transform.position = new Vector2(transform.position.x, 2.5f);
			}
			
			else if(transform.position.y >2.45f && transform.position.y <2.55f)
			{
				transform.position = new Vector2(transform.position.x, 4.2f);
			}
		}

		transform.position += Vector3.right * Time.deltaTime * ms;
	}

	void Ms_augmentation()
	{
		ms += Time.deltaTime * 0.2f;		//ms goes up per second
	}




}
