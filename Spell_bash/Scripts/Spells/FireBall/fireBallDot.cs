using UnityEngine;
using System.Collections;

public class fireBallDot : MonoBehaviour {

	public GameObject hero;
	public GameObject burn;
	public TextMesh text;
	public GameObject burnIconStack;
	public bool applyOneBurn;
	public int dotStack;
	public float dotDmg;
	public float timeUntilReset;
	public float time;
	
	
	private bool oneStackGoesDown;
	
	
	
	
	void Update()
	{
		DotDamage();
	}
	
	
	
	void DotDamage()
	{
		if(dotStack >= 1)
		{
			hero.GetComponent<heroStats>().health -= dotDmg * Time.deltaTime * dotStack;
			burnIconStack.active = true;
			text.text = "X" + dotStack;
			
			
			time+=Time.deltaTime;
			if(time >= timeUntilReset)
			{
				oneStackGoesDown = true;
			}
		}
		
		if(oneStackGoesDown == true)
		{
			if(dotStack>=0)
			{
				dotStack -=1;
				oneStackGoesDown =false;
				time = timeUntilReset;
				burnIconStack.active = false;
			}
		}
		
		if(applyOneBurn == true)
		{
			Instantiate(burn, transform.position, burn.transform.rotation = Quaternion.AngleAxis(270f, Vector3.right));
			applyOneBurn = false;
			//burn.transform.parent = transform;
			
		}
		burn.transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
		
	}
	
	
	
}
