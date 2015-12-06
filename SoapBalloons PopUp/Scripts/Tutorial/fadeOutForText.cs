using UnityEngine;
using System.Collections;

public class fadeOutForText : MonoBehaviour {

	private Color col;
	
	private bool firstCall;
	private bool secondCall;
	
	
	
	IEnumerator Start()
	{
		if(col.a<=255)
		{
			firstCall=true;
		}
		
		yield return new WaitForSeconds(3f);
		
		if(col.a>=0)
		{
			secondCall=true;
			firstCall = false;
		}
	}
	
	void Update()
	{
		if(firstCall==true)
		{
			col = GetComponent<TextMesh>().color;
			col.a += Time.deltaTime * 0.4f;
			GetComponent<TextMesh>().color = col;
		}
		
		if(secondCall==true)
		{
			col = GetComponent<TextMesh>().color;
			col.a -= Time.deltaTime * 0.4f;
			GetComponent<TextMesh>().color = col;
			
			
		}
	}
}
