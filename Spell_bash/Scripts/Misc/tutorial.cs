using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {


	public float time;

	public GameObject spell_One;
	public GameObject spell_Two;
	public GameObject spell_Three;
	public GameObject spell_Four;
	public GameObject spell_Five;
	public GameObject spell_Six;
	
	
	IEnumerator Start()
	{
		while(true)
		{
			Instantiate(spell_One, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(time);
			
			Instantiate(spell_Two, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(time);
			
			Instantiate(spell_Three, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(time);
			
			Instantiate(spell_Four, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(time);
			
			Instantiate(spell_Five, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(time);
			
			Instantiate(spell_Six, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(time);
		}
	}
}
