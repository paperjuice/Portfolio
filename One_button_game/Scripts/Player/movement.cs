using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float ms;
	public float cameraSpeed;
	public float switchSpeed;
	
	private bool rotateUp = true;
	private Vector3 c;
	private Vector3 d;
	
	private GameObject cameraMain;
	private Vector3 cameraA;
	private Vector3 cameraB;
	private float time = 1 ;
	
	void Awake()
	{
		cameraMain = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	void Update()
	{
		SpeedIncrease();
		Rotate();
	
		transform.position += transform.right * ms * Time.deltaTime;
		
		if(rotateUp == false)
		{
			
			//speed of scaling
			c = transform.localScale;
			if(c.y>=-1f)
			{
				
				c.y -= Time.deltaTime * switchSpeed;
				transform.localScale = c;
			}
			
			
			//camera position
			cameraB = cameraMain.transform.position;
			if(cameraB.y >= -18.4f)
			{
				cameraB.y -= Time.fixedDeltaTime *cameraSpeed;
				cameraMain.transform.position = cameraB;
			}
			
			
			//color change
			if(time >=0)
			{
				time -= Time.deltaTime * 3f;
			}
			GetComponent<SpriteRenderer>().color =new  Color(time, time, time, 1);
		}
		else
		{
			
			//speed of scaling
			d = transform.localScale;
			if(d.y<=1f)
			{
				
				d.y += Time.deltaTime * switchSpeed;
				transform.localScale = d;
			}			
			
			//camera position
			cameraA = cameraMain.transform.position;
			if(cameraA.y <= 6.8f)
			{
				cameraA.y += Time.fixedDeltaTime*cameraSpeed;
				cameraMain.transform.position = cameraA;
			}
			
			//color change
			if(time <=1)
			{
				time += Time.deltaTime * 3f;
			}
			GetComponent<SpriteRenderer>().color =new  Color(time, time, time, 1);
		}
		
	}

	
	void Rotate()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			if(rotateUp == false)
			{
				rotateUp = true;
			}
			else
			{
				rotateUp = false;
			}
		}
	}
	
	void SpeedIncrease()
	{
	
		//add condition later
		ms += Time.deltaTime * 0.3f;
		switchSpeed += Time.deltaTime * 0.03f;
		cameraSpeed += Time.deltaTime * 0.03f;
	}
}
