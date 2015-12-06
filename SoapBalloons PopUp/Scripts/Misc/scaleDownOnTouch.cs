using UnityEngine;
using System.Collections;

public class scaleDownOnTouch : MonoBehaviour {

//when I click on button it scales down


	public float scaleFactor;
	
	void OnMouseDown()
	{
		transform.localScale -= new Vector3(scaleFactor/1000, scaleFactor/1000, scaleFactor/1000);
	}
	void OnMouseUp()
	{
		transform.localScale += new Vector3(scaleFactor/1000, scaleFactor/1000, scaleFactor/1000);
	}
}
