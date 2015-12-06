using UnityEngine;
using System.Collections;

public class randomScale : MonoBehaviour {

	void Start()
	{
		float r = Random.value /10 ;
		
		transform.localScale -= new Vector3(r, r, r);
	}
}
