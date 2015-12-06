using UnityEngine;
using System.Collections;

public class numberOfTaps : MonoBehaviour {

	public int numberOfTapsAvailable;
	public TextMesh text;
	
	void Awake()
	{
		++numberOfTapsAvailable;
	}
	
	void Update()
	{
		if(Input.GetButtonDown("Fire1") && numberOfTapsAvailable!=0)
		{
			--numberOfTapsAvailable;
		}
		
		
		if(numberOfTapsAvailable>0)
		{
			text.text ="Taps:" + (numberOfTapsAvailable -1);
		}
		
		
		if(numberOfTapsAvailable<=0)
		{
			text.text ="Taps:0" ;
		}
	}
}
