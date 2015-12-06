using UnityEngine;
using System.Collections;

public class stunIconActivate : MonoBehaviour {

	private heroMovement heroMove;
	
	public GameObject stunIcon;
	
	void Awake()
	{
		heroMove = GetComponent<heroMovement>();
	}
	
	void Update()
	{
		if(heroMove.enabled == false)
		{
			stunIcon.active = true;
		}
		else
		{
			stunIcon.active = false;
		}
		
		
	}
}
