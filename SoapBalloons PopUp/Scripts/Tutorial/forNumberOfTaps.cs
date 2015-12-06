using UnityEngine;
using System.Collections;

public class forNumberOfTaps : MonoBehaviour {

	//so the text stay the same even if the "numberOfTaps" script stays the same
	
	void Update()
	{
		GetComponent<TextMesh>().text = "" + "Taps:3";
	}
}
