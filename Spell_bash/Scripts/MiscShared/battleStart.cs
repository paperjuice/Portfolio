using UnityEngine;
using System.Collections;

public class battleStart : MonoBehaviour {




////in the beginning of the battle will be a countdown while both players will be immobilized

	private GameObject[] players;

	public GameObject insBlue;
	public GameObject insRed;
	
	public float time;
	
	void Awake()
	{
		players = GameObject.FindGameObjectsWithTag("Player");
	}
	
	IEnumerator Start()
	{
		yield return new WaitForSeconds(time);
		
		foreach(GameObject player in players)
		{
			player.GetComponent<heroMovement>().enabled = true;
			player.GetComponent<heroStats>().enabled = true;
		}
		insBlue.active = true;
		insRed.active = true;
	}
}
