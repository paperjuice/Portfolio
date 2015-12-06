using UnityEngine;
using System.Collections;

public class hiddenScoreV2 : MonoBehaviour {

	public bool colorIsFading = false;
	
	private Color col;
	private float time=0f;
	private float endTime=1f;
	
	
	void Awake()
	{
		col = GetComponent<TextMesh>().color;
	}

	void Update()
	{
		Timer();
	
	
		if(colorIsFading == true && col.a<=1)
		{
			col.a += Time.deltaTime *8;
			GetComponent<TextMesh>().color = col;
		}
		else if( colorIsFading == false)
		{
			col.a-= Time.deltaTime *2;
			GetComponent<TextMesh>().color = col;
		}
	}
	
	void Timer()
	{
		if(colorIsFading == true && col.a>=0)
		{
			time+=Time.deltaTime;
			if(time>=endTime)
			{
				time=0;
				colorIsFading=false;
			}
		}
	}
}
