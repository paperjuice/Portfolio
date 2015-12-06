using UnityEngine;
using System.Collections;

public class redMovement : MonoBehaviour {

	public float ms;
	public float rs;
	
	private Rigidbody rigid;
	private float savedMs;
	
	void Awake()
	{
		rigid = GetComponent<Rigidbody>();
	}
	
	void Start()
	{
		savedMs = ms;
	}
	
	void FixedUpdate()
	{
		Move();
		Rotation();
	}
	
	void Move()
	{
		/*if(Input.GetKey("up") && Input.GetKey("right") || Input.GetKey("left") && Input.GetKey("down") || Input.GetKey("left")&&Input.GetKey("up") || Input.GetKey("down")&&Input.GetKey("right"))
		{
			ms =  707.1f;
		}
		else
		{
			ms = savedMs;
		}*/
	
		if(Input.GetKey("up"))
		{
			rigid.AddForce(Vector3.forward * ms);
		}
		
		if(Input.GetKey("down"))
		{
			rigid.AddForce(Vector3.forward * -ms);
		}
		
		if(Input.GetKey("right"))
		{
			rigid.AddForce(Vector3.right * ms);
		}
		
		if(Input.GetKey("left"))
		{
			rigid.AddForce(Vector3.right * -ms);
		}	
	}
	
	void Rotation()
	{
		if(Input.GetKey("right"))
		{
			Quaternion right  = Quaternion.AngleAxis(90f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
		
		if(Input.GetKey("left"))
		{
			Quaternion right  = Quaternion.AngleAxis(270f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
		
		if(Input.GetKey("down"))
		{
			Quaternion right  = Quaternion.AngleAxis(180f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
		
		if(Input.GetKey("up"))
		{
			Quaternion right  = Quaternion.AngleAxis(0f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
	}
}
