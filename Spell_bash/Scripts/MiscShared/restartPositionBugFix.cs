using UnityEngine;
using System.Collections;

public class restartPositionBugFix : MonoBehaviour {

	private Vector3 positioning;

	void Update()
	{
		positioning = transform.position;
		
		if(positioning.x>=50 || positioning.x>=-50 || positioning.z >=-50 ||positioning.z >=50 )
		{
			transform.position = new Vector3(Random.Range(-22f,22f), 10f, Random.Range(-9f,9f));
		}
	}
}
