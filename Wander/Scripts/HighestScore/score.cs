using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	public float scoreText;
	
	private GameObject player;
	private Vector3 playerDistance;
	
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update()
	{
		playerDistance = player.transform.position;
	
		scoreText = playerDistance.y;
		
		GetComponent<TextMesh>().text =""+ scoreText.ToString("N0");
	}
}
