using UnityEngine;
using System.Collections;

public class rotate_behaviour : MonoBehaviour {

	
	//rotation speed
	public float rs;

	//what direction it rotates
	private int direction = 1;
	private int r;

	//how fast the rs goes up;
	private float multi = 0.5f;

	//it goes down once when it reaches a certain rs
	private bool first_fluctuation = false;

	public int time_between_random = 10;


	IEnumerator Start()
	{
		while (true)
		{
			r = Random.Range(1, 3);

			if (time_between_random>3)
			{
				time_between_random--;
			}

			yield return new WaitForSeconds(time_between_random);
		}
	}

	void Update()
	{
		Random_direction();
		Speed_increase();
		Rotate();
		Speed_Fluctuation();
	}

	void Random_direction()
	{
		if (r == 1)
		{
			direction = 1;
		}
		else if (r == 2)
		{
			direction = -1;
		}
	}

	void Speed_increase()
	{
		if (rs < 80f)
		{
			rs += Time.deltaTime * multi;
		}
	}

	void Rotate()
	{
		transform.Rotate( Time.deltaTime * rs * transform.forward * direction);
	}

	void Speed_Fluctuation()
	{
		if (rs >= 40)
		{
			if (first_fluctuation == false)
			{
				rs = 10;
				multi = 5f;
				first_fluctuation = true;
			}
		}
	}
}
