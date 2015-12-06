using UnityEngine;
using System.Collections;

public class ins_obj : MonoBehaviour
{

	//Dragos Dumitru


	public GameObject coins;
	public GameObject mines;

	public float time;         //time between each coin/mine;

	public float top;
	public float mid;
	public float bot;


	private int r_drop;
	private int r_position;


	IEnumerator Start()													
	{
		while (true)
		{
			r_drop = Random.Range(1, 100);			//random drop between coin and mine

			if (r_drop >= 30 && r_drop < 100)			//drop chance for coin
			{
				//ins on a specific lane based on a random number

				r_position = Random.Range(1, 4);		

				if (r_position == 1)
				{
					Instantiate(coins, transform.position = new Vector2(transform.position.x, top), transform.rotation);
				}

				if (r_position == 2)
				{
					Instantiate(coins, transform.position = new Vector2(transform.position.x, mid), transform.rotation);
				}

				if (r_position == 3)
				{
					Instantiate(coins, transform.position = new Vector2(transform.position.x, bot), transform.rotation);
				}
			}

			else if (r_drop >= 1 && r_drop < 30)			//drop rate for mines
			{
				r_position = Random.Range(1, 4);

				if (r_position == 1)
				{
					Instantiate(mines, transform.position = new Vector2(transform.position.x, top), transform.rotation);
				}

				if (r_position == 2)
				{
					Instantiate(mines, transform.position = new Vector2(transform.position.x, mid), transform.rotation);
				}

				if (r_position == 3)
				{
					Instantiate(mines, transform.position = new Vector2(transform.position.x, bot), transform.rotation);
				}
			}



			yield return new WaitForSeconds(time);		//amount of time between next drop
		}
	}



	void Update()					//time between drop is reduced every second
	{
		if (time >= 0.2f) 
		{
			time -= Time.deltaTime * 0.01f;
		}
	}
}