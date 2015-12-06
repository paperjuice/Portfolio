using UnityEngine;
using System.Collections;

public class activeDeactive : MonoBehaviour {

//activate panel on mouse down

	private GameObject[] bullets;

	public GameObject name;
	

	void OnMouseDown()
	{
		bullets = GameObject.FindGameObjectsWithTag("bullet");
		
		
		if(name.active==false)
		{
			name.active = true;
			
			foreach(GameObject bullet in bullets)
			{
				bullet.GetComponent<bulletMove>().enabled=false;
			}
		}
		else if(name.active == true)
		{
			name.active = false;
			
			foreach(GameObject bullet in bullets)
			{
				bullet.GetComponent<bulletMove>().enabled=true;
			}
		}
	}
}
