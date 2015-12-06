using UnityEngine;
using System.Collections;

public class heroMovement : MonoBehaviour {

	public string tag;
	public KeyCode keyUp;
	public KeyCode keyDown;
	public KeyCode keyRight;
	public KeyCode keyLeft;

	public float savedMs;
	public float ms;
	public float rs;
	
	private Rigidbody rigid;
	private AudioSource audio;
	private GameObject blueBody;
	
	void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		audio = GetComponent<AudioSource>();
		blueBody = GameObject.FindGameObjectWithTag(tag);
	}
	
	void Start()
	{
		savedMs = ms;
	}
	
	void FixedUpdate()
	{
		rigid.WakeUp();
	
		Move();
		Rotation();
		FootStepsSound();
		Animator();
	}
	
	void Move()
	{
		/*if(Input.GetKey(keyUp) && Input.GetKey(keyRight) || Input.GetKey(keyLeft) && Input.GetKey(keyDown) || Input.GetKey(keyLeft)&&Input.GetKey(keyUp) || Input.GetKey(keyDown)&&Input.GetKey(keyRight))
		{
			ms =  2207.1f;
		}
		else
		{
			ms = savedMs;
		}*/
	
		if(Input.GetKey(keyUp))
		{
			//rigid.AddForce(Vector3.forward * ms);
			//rigid.velocity = (Vector3.forward * ms);
			transform.position += Vector3.forward * ms * Time.deltaTime;
			
		}
		
		if(Input.GetKey(keyDown))
		{
			//rigid.AddForce(Vector3.forward * -ms);
			//rigid.velocity = (Vector3.forward * -ms);
			transform.position += Vector3.forward * -ms * Time.deltaTime;
		}
		
		if(Input.GetKey(keyRight))
		{
			//rigid.AddForce(Vector3.right * ms);
			//rigid.velocity = (Vector3.right * ms);
			transform.position += Vector3.right * ms * Time.deltaTime;
		}
		
		if(Input.GetKey(keyLeft))
		{
			//rigid.AddForce(Vector3.right * -ms);
			//rigid.velocity = (Vector3.right * -ms);
			transform.position += Vector3.right * -ms * Time.deltaTime;
		}	
	}
	
	void Rotation()
	{
		if(Input.GetKey(keyRight))
		{
			Quaternion right  = Quaternion.AngleAxis(90f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
		
		if(Input.GetKey(keyLeft))
		{
			Quaternion right  = Quaternion.AngleAxis(270f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
		
		if(Input.GetKey(keyDown))
		{
			Quaternion right  = Quaternion.AngleAxis(180f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
		
		if(Input.GetKey(keyUp))
		{
			Quaternion right  = Quaternion.AngleAxis(0f , Vector3.up);
			transform.rotation = Quaternion.Lerp(transform.rotation, right, rs* Time.deltaTime);
		}
	}
	
	void FootStepsSound()
	{
		if(Input.GetKey(keyUp) || Input.GetKey(keyDown) || Input.GetKey(keyRight) || Input.GetKey(keyLeft))
		{
			audio.enabled = true;
		}
		else
		{
			audio.enabled = false;
		}
	}
	
	void Animator()
	{
		if(Input.GetKey(keyUp) || Input.GetKey(keyDown) || Input.GetKey(keyRight) || Input.GetKey(keyLeft))
		{
			blueBody.GetComponent<activateAnim>().walk = true;
		}
		else
		{
			blueBody.GetComponent<activateAnim>().walk = false;
		}
	}
	
	
}
