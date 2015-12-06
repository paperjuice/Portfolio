using UnityEngine;
using System.Collections;

public class stopFromGettingMinusScore : MonoBehaviour {

	public GameObject panel; 


	void OnTriggerEnter2D()
	{
		panel.gameObject.active = true;
	}
}
