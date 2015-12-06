using UnityEngine;
using System.Collections;

public class activateAnim : MonoBehaviour {

	public bool walk;
	public bool dead;
	
	private Animator anim;
	private GameObject[] players;
	private GameObject[] burns;
	
	void Awake()
	{
		anim = GetComponent<Animator>();
		players = GameObject.FindGameObjectsWithTag("Player");
		
	}

	
	void Update()
	{
		Walk();
		Dead();
	}
	
	void Walk()
	{
		if(walk == true)
		{
			anim.SetBool("walk", true);
		}
		else
		{
			anim.SetBool("walk", false);
		}
	}
	
	void Dead()
	{
		if(dead == true)
		{
			anim.SetTrigger("dead");
			
			foreach(GameObject player in players)
			{
				player.GetComponent<heroStats>().enabled = false;
				player.GetComponent<heroMovement>().rs = 0f;
				player.GetComponent<heroMovement>().ms = 0f;
			}
			enabled = false;
			
			burns = GameObject.FindGameObjectsWithTag("burn");
			
			foreach(GameObject burn in burns)
			{
				burn.SetActive(false);
			}
			
		}
	}
}
