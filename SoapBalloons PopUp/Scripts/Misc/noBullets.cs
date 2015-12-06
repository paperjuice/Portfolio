using UnityEngine;
using System.Collections;

public class noBullets : MonoBehaviour {

//if there are no bullets on screen restart button will pop

	private GameObject[] bullets;
	private GameObject[] balloons;
	
	public GameObject panel;
	
	


	IEnumerator Start()
	{
		while(true)
		{
			bullets = GameObject.FindGameObjectsWithTag("bullet");
			balloons = GameObject.FindGameObjectsWithTag("balloon");
			yield return new WaitForSeconds(0.1f);
		}
	}
	
	void Update()
	{
		if(bullets.Length == 0 && balloons.Length !=0)
		{
			panel.active=true;
		}
	}
}
