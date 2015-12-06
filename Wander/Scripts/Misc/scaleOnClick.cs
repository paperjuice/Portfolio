using UnityEngine;
using System.Collections;

public class scaleOnClick : MonoBehaviour {
		
	public float value;
	
	void OnMouseDown()
	{
		transform.localScale -= new Vector3(value, value, value);
	}
	
	void OnMouseUp()
	{
		transform.localScale += new Vector3(value, value, value);
	}
}
