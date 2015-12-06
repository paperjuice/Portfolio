using UnityEngine;
using System.Collections;

public class coin_collector : MonoBehaviour {


	//Dragos Dumitru


	private GameObject[] coins;				//take all coins tag
	private GameObject[] mines;				//take all mines tag

	public GameObject coin_particle;		//the particles that will show when the coins explode
	public GameObject lose_panel;			//the panel that will pop when we lose

	public TextMesh text;
	public int score;


	IEnumerator Start()
	{
		//take the tag every 0.1f seconds so new instances of the object are added to the list
		while (true)
		{
			coins = GameObject.FindGameObjectsWithTag("Coin");
			mines = GameObject.FindGameObjectsWithTag("Mine");
			
			yield return new WaitForSeconds(0.1f);
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{

		//if the player touches the coin the score gets ++, we ins the "coin_particle" and we also destroy the coin
		foreach (GameObject coin in coins)
		{
			if (col.gameObject == coin)
			{
				Instantiate(coin_particle, coin.transform.position, transform.rotation);
				Destroy(coin.gameObject);
				score++;
				//print("asd");
			}
		}

		//if the player touches a mine, the score gets - 10
		foreach (GameObject mine in mines)
		{
			if (col.gameObject == mine)
			{
				score -= 10;
			}
		}
	}

	void Update()
	{
		Score_text();
		//Won_game();
		Game_lost();
	}

	//reference to the text mesh that will show the score
	void Score_text()
	{
		text.text = "" + score;
	}

	//if the score gets to 0, the player loses the game and the panel with who won appears
	void Won_game()
	{
		if (score < 0)
		{
			lose_panel.SetActive(true);
			gameObject.SetActive(false);
			Time.timeScale = 0f;			//we set the in-game time to 0 so the second player can't lose
		}
	}

	void Game_lost()
	{
		if (score < 0)
		{
			lose_panel.SetActive(true);
			Time.timeScale = 0f;
		}
	}
}
