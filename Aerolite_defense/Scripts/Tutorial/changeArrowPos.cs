using UnityEngine;
using System.Collections;

public class changeArrowPos : MonoBehaviour {

	
	//arrow pos from shield to lives

	private Animator anim;
	private bool changeText;


	public GameObject arrowFirst; // asta dispare prima
	public GameObject arrowSecond; // asta dispare a doua
	public GameObject text;


	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	IEnumerator Start()
	{
		yield return new WaitForSeconds(10f);

		changeText = true;

		yield return new WaitForSeconds(3f);

		changeText = false;

		text.GetComponent<TextMesh>().text = "Try to get as many" + "\n" + "poins as possible!";
		arrowFirst.SetActive(false);
		arrowSecond.SetActive(true);
	}

	void Update()
	{
		if (changeText == true)
		{
			Color col = GetComponent<TextMesh>().color;

			col.a -= Time.deltaTime * 0.8f;
			text.GetComponent<TextMesh>().color = col;

		}

		if (changeText == false)
		{
			Color col = GetComponent<TextMesh>().color;

			col.a += Time.deltaTime;
			text.GetComponent<TextMesh>().color = col;

		}
	}

}
