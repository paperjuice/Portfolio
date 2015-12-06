using UnityEngine;
using System.Collections;

public class hellGate_gate : MonoBehaviour {

	public GameObject spirits;
	public float timeToCharge;
	public float spawnSpeed;
	public float health;

	IEnumerator Start()
	{
		transform.position -= new Vector3(0,1.1f,0);
	
		yield return new WaitForSeconds(timeToCharge);
		
		
		
		while(true)
		{
			Instantiate(spirits, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(spawnSpeed);
		}
	}
	
	void Update()
	{
		if(health<=0)
		{
			Destroy(gameObject);
		}
	}
}
