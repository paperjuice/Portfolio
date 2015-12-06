using UnityEngine;
using System.Collections;

public class fadeInAfterSomeTime : MonoBehaviour {
//was too lazy to modify the existing one 

	public float time;
	public GameObject button;
	
	private bool fadeIn;
	
	IEnumerator Start()
	{
		while(true)
		{
			yield return new WaitForSeconds(time);
			fadeIn=true;
			
		}
	}
	
	void Update()
	{
		if(fadeIn == true)
		{
			Color col = renderer.material.color;
			col.a-=Time.deltaTime*3;
			renderer.material.color = col;
			
			button.active=true;
		}
	}
}
