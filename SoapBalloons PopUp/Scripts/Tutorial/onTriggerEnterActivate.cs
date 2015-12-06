using UnityEngine;
using System.Collections;

public class onTriggerEnterActivate : MonoBehaviour {

	public GameObject panel;

	void OnTriggerEnter2D()
	{
		panel.active = true;
	}
}
