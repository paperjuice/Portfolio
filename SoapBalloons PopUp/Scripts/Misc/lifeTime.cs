using UnityEngine;
using System.Collections;

public class lifeTime : MonoBehaviour {

	public float time = 20;


	IEnumerator Start()
	{
		yield return new WaitForSeconds(time);
		{
			Destroy(gameObject);
		}
	}
}
