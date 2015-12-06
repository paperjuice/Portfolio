using UnityEngine;
using System.Collections;

public class disableComponentAfterTime : MonoBehaviour {

	public float time;
	public int whichOneIsDisabled;
	
	
	// 1 for box
	// 2 for sphere
	
	
	
	IEnumerator Start()
	{
		yield return new WaitForSeconds(time);
		
		if(whichOneIsDisabled == 1)
		{
			DisableBoxCollider();
		}
		
		if(whichOneIsDisabled == 2)
		{
			DisableSphereCollider();
		}
		
	}
	
	void DisableBoxCollider()
	{
		GetComponent<BoxCollider>().enabled = false;
	}
	
	void DisableSphereCollider()
	{
		GetComponent<SphereCollider>().enabled = false;
	}
	
	
	
}
