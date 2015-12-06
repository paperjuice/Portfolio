using UnityEngine;
using System.Collections;

public class wallOfDeathOnPlayer : MonoBehaviour {

	public int wallOfDeathStacks;
	public float dmg;
	public float debuffTime;
	
	private heroStats stats;
	private float timer;
	
	void Awake()
	{
		stats = GetComponent<heroStats>();
	}
	
	void FixedUpdate()
	{
		if(wallOfDeathStacks==2)
		{
			stats.health -= dmg;
			wallOfDeathStacks = 0;
		}
		
		if(wallOfDeathStacks >0)
		{
			timer += Time.deltaTime;
			if(timer>= debuffTime)
			{
				wallOfDeathStacks = 0;
				timer =0;
			}
		}
	}
}
