using UnityEngine;
using System.Collections;

public class insParticles : MonoBehaviour {

	public GameObject particles;
	
	void Start()
	{
		Instantiate(particles, transform.position, Quaternion.identity);
	}
}
