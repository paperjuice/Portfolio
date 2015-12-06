using UnityEngine;
using System.Collections;

public class blueMovement : MonoBehaviour {

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
		/*if(Input.GetKey("w") && Input.GetKey("d") || Input.GetKey("a") && Input.GetKey("s") || Input.GetKey("a")&&Input.GetKey("w") || Input.GetKey("s")&&Input.GetKey("d"))
		{
			ms =  707.1f;
		}
		else
		{
			ms = savedMs;
		}*/
	
		if(Input.GetKey("w"))
		{
			rigid.AddForce(Vector3.forward * ms);
		}
		
		if(Input.GetKey("s"))
		{
			rigid.AddForce(Vector3.forward * -ms);
		}
		
		if(Input.GetKey("d"))
		{
			rigid.AddForce(Vector3.right * ms);
		}
		
		if(Input.GetKey("a"))
		{
			rigid.AddForce(Vector3.right * -ms);
		}	
		
	}
	
	void Rotation()
	{
		if(Input.GetKey("d"))
		{
			Quaternion right  = Quaternion.AngleAxis(90f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
		
		if(Input.GetKey("a"))
		{
			Quaternion right  = Quaternion.AngleAxis(270f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
		
		if(Input.GetKey("s"))
		{
			Quaternion right  = Quaternion.AngleAxis(180f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
		
		if(Input.GetKey("w"))
		{
			Quaternion right  = Quaternion.AngleAxis(0f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
	}
	
}
