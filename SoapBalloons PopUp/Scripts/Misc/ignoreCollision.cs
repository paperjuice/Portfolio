using UnityEngine;
using System.Collections;

public class ignoreCollision : MonoBehaviour {

//bullets ignore collision with ui 

	public string writeTheTagHere;
	
	private GameObject theObject;
	
	
	void Awake()
	{
		theObject = GameObject.FindGameObjectWithTag(writeTheTagHere);
	}
	
	void Update()
	{
		
		if(theObject!=null)
		Physics2D.IgnoreCollision(GetComponent<CircleCollider2D>(), theObject.GetComponent<CircleCollider2D>(), true);
	}
}
