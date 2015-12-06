using UnityEngine;
using System.Collections;

public class incurajare : MonoBehaviour {


	private int r;
	
	
	void Awake()
	{
		r = Random.Range(1,6);
	}
	
	void Update()
	{
		if(r==1)
		{
			GetComponent<TextMesh>().text="Don't give up!";
		}
		
		if(r==2)
		{
			GetComponent<TextMesh>().text="Try again!";
		}
		
		if(r==3)
		{
			GetComponent<TextMesh>().text="You can do it!";
		}
		
		if(r==4)
		{
			GetComponent<TextMesh>().text="I believe in you!";
		}
		
		if(r==5)
		{
			GetComponent<TextMesh>().text="You almost\n done it!";
		}
	}


}
