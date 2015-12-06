using UnityEngine;
using System.Collections;

public class insSpells : MonoBehaviour {

	public GameObject cd_icon;
	public GameObject hero;
	public GameObject spell;
	public GameObject sound;
	public KeyCode key;
	public float cd;
	public float manaCost;

	private float max_cd;
	private float timer;
	private bool onCd;


	void Start()
	{
		max_cd = cd;
	}
	
	void Update()
	{
		Attack();
		Cd_();
	}
	
	void Attack()
	{
		if(Input.GetKeyDown(key))
		{
			if(onCd == false && manaCost <= hero.GetComponent<heroStats>().mana)
			{
				onCd = true;
				Instantiate(spell, transform.position, transform.rotation);
				Instantiate(sound, transform.position, transform.rotation);
				hero.GetComponent<heroStats>().mana -= manaCost;
			}
		}
		
		if(onCd == true)
		{
			timer += Time.deltaTime;
			if(timer >= cd)
			{
				onCd = false;
				timer=0f;
			}
		}	
	}

	void Cd_()
	{
		cd_icon.transform.localScale = new Vector2(1f, (timer / max_cd ) );
	}
}
