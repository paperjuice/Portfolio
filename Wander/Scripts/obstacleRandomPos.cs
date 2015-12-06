using UnityEngine;
using System.Collections;

public class obstacleRandomPos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		float r = Random.Range(-25f, 30f);
		transform.position +=  new Vector3(r, 0f, 0f);
	}
	
	
}
