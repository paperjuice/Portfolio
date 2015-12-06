using UnityEngine;
using System.Collections;

public class levelBalloonBehaviour : MonoBehaviour {

	public GameObject particles;
	public GameObject sound_1;
	public GameObject sound_2;
	public GameObject sound_3;
	public GameObject sound_4;
	
	
	private int r;
	
	void Awake()
	{
		r=Random.Range(1,5);
	}
	
	void OnCollisionEnter2D()
	{
		Destroy(gameObject);
		Instantiate(particles, transform.position, transform.rotation);
		
		if(r==1)
		{
			Instantiate(sound_1, transform.position, transform.rotation);
		}
		
		if(r==2)
		{
			Instantiate(sound_2, transform.position, transform.rotation);
		}
		
		if(r==3)
		{
			Instantiate(sound_3, transform.position, transform.rotation);
		}
		
		if(r==4)
		{
			Instantiate(sound_4, transform.position, transform.rotation);
		}
	}
}
