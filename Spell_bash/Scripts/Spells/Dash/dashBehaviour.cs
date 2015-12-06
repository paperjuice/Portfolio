using UnityEngine;
using System.Collections;

public class dashBehaviour : MonoBehaviour {

	public GameObject cd_icon;
	public GameObject particles;
	public GameObject audio;
	public KeyCode key;
	//public float dashPower;
	public float manaCost;
	public float cd;
	public float teleportDistance;
	
	private float mana_on_start;
	private Rigidbody rigid;
	private heroStats stats;
	private bool onCd;
	private float timer;
	private Ray fromRay;
	private RaycastHit raycast;
	
	
	void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		stats = GetComponent<heroStats>();
	}

	IEnumerator Start()
	{
		mana_on_start = manaCost;
		manaCost = 9000000f;
		yield return new WaitForSeconds(3f);
		manaCost = mana_on_start; 
		
	}

	void Update()
	{
		//Attack();
		Dash();
		Cd_();
	}
	
	
	/*void Attack()
	{
		if(Input.GetKeyDown(key))
		{
			if(onCd == false && manaCost <=stats.mana)
			{
				onCd = true;
				rigid.velocity = transform.forward * dashPower;
				stats.mana -= manaCost;
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
	}*/
	
	void Dash()
	{
		fromRay.origin = transform.position;
		fromRay.direction = transform.forward;
	
		if(Input.GetKeyDown(key))
		{
			if(onCd == false && manaCost <=stats.mana)
			{
				Instantiate(particles, transform.position, transform.rotation);
				Instantiate(audio, transform.position, transform.rotation);
			
				if(Physics.Raycast(fromRay, out raycast, teleportDistance))
				{
					transform.position = new Vector3( raycast.point.x, 0, (raycast.point.z ));
				}
				else
				{
					transform.position += transform.forward * teleportDistance;
				}
				
				onCd = true;
				stats.mana -= manaCost;
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
		cd_icon.transform.localScale = new Vector2(1f, (timer / cd));
	}
	
}
