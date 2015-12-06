using UnityEngine;
using System.Collections;

public class insShipMainMenu : MonoBehaviour {

	public GameObject projectile;
	public float seconds;

	IEnumerator Start()
	{
		while(true)
		{
			Instantiate(projectile, transform.position, transform.rotation);
			
			yield return new WaitForSeconds(seconds);
		}
	}
}
