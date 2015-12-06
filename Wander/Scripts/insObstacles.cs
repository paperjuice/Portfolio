using UnityEngine;
using System.Collections;

public class insObstacles : MonoBehaviour {

	public GameObject obstacle;
	public float seconds;
	
	IEnumerator Start()
	{
		while(true)
		{
			if(seconds>=3f)
			{
				seconds -=0.3f;
			}
		
			Instantiate(obstacle, transform.position , transform.rotation);
				
			yield return new WaitForSeconds(seconds);
		}
	}
	
	void Update()
	{
		InactiveUntilTap();
	}
	
	void InactiveUntilTap()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			enabled = true;
		}
	}
	
}
