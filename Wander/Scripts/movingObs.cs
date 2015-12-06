using UnityEngine;
using System.Collections;

public class movingObs: MonoBehaviour {

	public float speed = 0.2f;
	
	private int r;
	private GameObject score;
	
	void Awake()
	{
		score = GameObject.FindGameObjectWithTag("score");
	}
	
	void Start()
	{
		r = Random.Range(1,6);
	}
	
	void Update()
	{
		if(score.GetComponent<score>().scoreText >= 4000)
		{
			if(r==1)
			{
				transform.position += transform.right * -speed * Time.deltaTime;
			}
		
			if(r==2)
			{
				transform.position += transform.right * speed * Time.deltaTime;
			}
		}
	}


}
