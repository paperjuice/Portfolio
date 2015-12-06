using UnityEngine;
using System.Collections;

public class fadeOut : MonoBehaviour {

	private Color col;
	private GameObject bullet;
	private GameObject taps;
	private bool firstCall;
	private bool secondCall;
	
	void Awake()
	{
		bullet = GameObject.FindGameObjectWithTag("bullet");
		taps = GameObject.FindGameObjectWithTag("numberOfTaps");
	}
	
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
		
		yield return new WaitForSeconds(1f);
		{
			bullet.GetComponent<bulletMove>().enabled = true;
			taps.GetComponent<numberOfTaps>().enabled = true;
		}
	}
	
	void Update()
	{
		if(firstCall==true)
		{
			col = GetComponent<SpriteRenderer>().color;
			col.a += Time.deltaTime * 0.4f;
			GetComponent<SpriteRenderer>().color = col;
		}
		
		if(secondCall==true)
		{
			col = GetComponent<SpriteRenderer>().color;
			col.a -= Time.deltaTime * 0.4f;
			GetComponent<SpriteRenderer>().color = col;
			
			
		}
	}
}
