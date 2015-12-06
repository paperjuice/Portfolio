using UnityEngine;
using System.Collections;

public class shipMainMenuBehaviour : MonoBehaviour {

	private int r;
	private float moveSpeed;
	private float rotateSpeed;
	
	private GameObject cameraMain;
	
	public GameObject particles;
	public GameObject audio;
	
	void Awake()
	{
		cameraMain = GameObject.FindGameObjectWithTag("MainCamera");
	}
	
	void Start()
	{
		moveSpeed = Random.Range(1f, 4f);
		rotateSpeed = Random.Range(250f, 350f);
	}
	
	void Update()
	{
		r = Random.Range(1,3);
		
		if(r==1)
		{
			transform.position += transform.up *moveSpeed * Time.deltaTime;
			transform.Rotate( transform.forward *rotateSpeed* Time.deltaTime);
		}
		if(r==2)
		{
			transform.position += transform.up  * moveSpeed * Time.deltaTime;
			transform.Rotate( transform.forward * rotateSpeed * -Time.deltaTime);
		}
	}
	
	void OnCollisionEnter2D()
	{
		enabled = false;
		Instantiate(particles, transform.position, transform.rotation);
		Instantiate(audio, transform.position, transform.rotation);
		GetComponent<SpriteRenderer>().enabled = false;
		GetComponent<CircleCollider2D>().enabled = false;
		Destroy(gameObject, 1f);

		cameraMain.GetComponent<Animator>().SetTrigger("shake");
	}
}
