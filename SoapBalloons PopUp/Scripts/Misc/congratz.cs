using UnityEngine;
using System.Collections;

public class congratz : MonoBehaviour {


	private int r;
	
	
	void Awake()
	{
		r = Random.Range(1,6);
	}
	

    //every time you win 
	void Update()
	{
		if(r==1)
		{
			GetComponent<TextMesh>().text="WoW! You're very\n smart!";
		}
		
		if(r==2)
		{
			GetComponent<TextMesh>().text="Well done!";
		}
		
		if(r==3)
		{
			GetComponent<TextMesh>().text="You're brilliant!";
		}
		
		if(r==4)
		{
			GetComponent<TextMesh>().text="I knew you could \n do it!";
		}
		
		if(r==5)
		{
			GetComponent<TextMesh>().text="Good job!";
		}
	}

}
