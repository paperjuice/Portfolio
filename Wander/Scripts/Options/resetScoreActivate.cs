using UnityEngine;
using System.Collections;

public class resetScoreActivate : MonoBehaviour {

	public GameObject panel;

	void OnMouseDown()
	{
		if(panel.active == false)
		{
			panel.active = true;
		}
		else
		{
			panel.active = false;
		}
	}
}
