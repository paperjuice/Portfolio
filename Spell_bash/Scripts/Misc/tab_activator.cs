using UnityEngine;
using System.Collections;

public class tab_activator : MonoBehaviour {

	public GameObject tab_object;
	public bool activate_tab = false;

	float time = 0f;
	float end_time = 4f;

	void Update()
	{


		if (activate_tab == true) 
		{
			time += Time.deltaTime;
			if(time >= end_time)
			{
				tab_object.SetActive(true);
			}
		}
	}
}
