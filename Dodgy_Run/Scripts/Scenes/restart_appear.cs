using UnityEngine;
using System.Collections;

public class restart_appear : MonoBehaviour {

	private GameObject player;
	public GameObject tab;

	IEnumerator Start()
	{
		while (true) 
		{
			player = GameObject.FindGameObjectWithTag ("Player");

			yield return new WaitForSeconds (0.1f);
		}
	}

	void Update()
	{
		if (player == null) 
		{
			tab.gameObject.SetActive (true);
		}
	}
}
