using UnityEngine;
using System.Collections;

public class bubble_position : MonoBehaviour {

	public TextMesh text;
	public string tag_name;
	public float x;
	public float y;
	public float z;
	
	private int r;
	private GameObject player;

	private string text_1 = "Dead meat,\nbi*ch!";
	private string text_2 = "Sleep with\nthe fishes,\ntw*t!";
	private string text_3 = "Get shREKT!";
	private string text_4 = "Not even\nclose, loser!";
	private string text_5 = "Try again,\ncupcake!";
	private string text_6 = "You're too\ngood,\npumpkin!";
	private string text_7 = "You're too good,\nsweetpea!";


	void Awake()
	{
		player = GameObject.FindGameObjectWithTag (tag_name);
	}

	void Start()
	{
		r = Random.Range (1, 8);

		if (r == 1) 
		{
			text.text = text_1;
		}

		if (r == 2) 
		{
			text.text = text_2;
		}
		if (r == 3) 
		{
			text.text = text_3;
		}
		if (r == 4) 
		{
			text.text = text_4;
		}
		if (r == 5) 
		{
			text.text = text_5;
		}
		if (r == 6) 
		{
			text.text = text_6;
		}
		if (r == 7) 
		{
			text.text = text_7;
		}
	}

	void Update()
	{
		transform.position = new Vector3 (player.transform.position.x + x, player.transform.position.y + y, player.transform.position.z + z);
	}
}
