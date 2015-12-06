using UnityEngine;
using System.Collections;

public class fadeIn : MonoBehaviour {

	private Color col;
	
	void Update()
	{
		if(col.a>=0)
		{
			col = GetComponent<SpriteRenderer>().color;
			col.a -= Time.deltaTime * 0.4f;
			GetComponent<SpriteRenderer>().color = col;
		}
		
		
	}


	
}
