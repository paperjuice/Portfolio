using UnityEngine;
using System.Collections;

public class fadeInText : MonoBehaviour {

	public float seconds;

	private Color col;
	private bool fadeIn = false;
	
	IEnumerator Start()
	{
		while(true)
		{
			yield return new WaitForSeconds(seconds);
			fadeIn =true;
		}
	}
	
	void Update()
	{
		if(fadeIn == true)
		{
			if(col.a >=0)
			{
				col = GetComponent<TextMesh>().color;
				col.a -=Time.deltaTime;
				GetComponent<TextMesh>().color = col;
			}
		}
	}
}
