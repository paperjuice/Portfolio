using UnityEngine;
using System.Collections;

public class noBulletsTutorialEdition : MonoBehaviour {

	private GameObject[] bullets;

	public bool merge = false;
	public GameObject panel;
	

	IEnumerator Start()
	{
		while(true)
		{
			bullets = GameObject.FindGameObjectsWithTag("bullet");
			yield return new WaitForSeconds(0.1f);
		}
	}
	
	void OnTriggerEnter2D()
	{
		merge=true;
	}
	
	void Update()
	{
		if(bullets.Length == 0 && merge == false)
		{
			panel.active=true;
		}
	}
}
