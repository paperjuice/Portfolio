using UnityEngine;
using System.Collections;

public class hiddenScore : MonoBehaviour {


	
	public bool colorIsFading = false;
	
	private Color col;
	private float time=0f;
	private float endTime=1f;
	public int score;
	
	void Awake()
	{
		col = GetComponent<TextMesh>().color;
	}
	
	
	void Update()
	{
		Timer();
		ScoreText();
	
	
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
	
	void ScoreText()
	{
		//GetComponent<TextMesh>().text = "Balloons Popped:";
		GetComponent<TextMesh>().text = ""+score;
	}
}
