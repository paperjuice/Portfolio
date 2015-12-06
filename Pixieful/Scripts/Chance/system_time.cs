using UnityEngine;
using System.Collections;
using System;

public class system_time : MonoBehaviour {

    public int day;




	void Update()
	{
        day = System.DateTime.Now.Day;
		
	}
	
}
