using UnityEngine;
using System.Collections;

public class stunSymbol : MonoBehaviour {

	public GameObject hero;

	void Update()
	{
		transform.position = new Vector3(hero.transform.position.x, transform.position.y, hero.transform.position.z);
	}
}
