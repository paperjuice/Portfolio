using UnityEngine;
using System.Collections;

public class textForTutorial : MonoBehaviour {


	public GameObject panelOne;
	
	
	
	private bool panelOneGetColored; 
	private bool disableBulletPanel;
	
	private Color col;
	private GameObject bullet;
	private GameObject taps;
	
	
	void Awake()
	{
		bullet = GameObject.FindGameObjectWithTag("bullet");
		taps = GameObject.FindGameObjectWithTag("numberOfTaps");
	}


	IEnumerator Start()
	{
		//while(true)
		{
			GetComponent<TextMesh>().text="Welcome to\nthe tutorial!";
		
			yield return new WaitForSeconds(3f);
			{
				GetComponent<TextMesh>().text="";
			}
			
			//yield return new WaitForSeconds(3.5f);
			{
				GetComponent<TextMesh>().text=" " + "We will go\nquick through\n  the basics.";
			}
			yield return new WaitForSeconds(3f);
			
			
			{
				GetComponent<TextMesh>().text="" + "This is your\nmain bullet.";
				panelOne.active=true;
				panelOneGetColored=true;
			}
			yield return new WaitForSeconds(3f);
			
			
			{
				GetComponent<TextMesh>().text="" + "TAP anywhere \n on the sceeen \n  to fire it!";
			}
			yield return new WaitForSeconds(1f);
			
			{
				bullet.GetComponent<bulletMove>().enabled = true;
				taps.GetComponent<numberOfTaps>().enabled = true;
				taps.GetComponent<forNumberOfTaps>().enabled = false;
				disableBulletPanel = true;
			}
			
			
		}
		
	}
	
	void Update()
	{
		if(panelOneGetColored==true)
		{
			col = panelOne.GetComponent<SpriteRenderer>().color;
			    col.a += Time.deltaTime * 0.9f;
			   panelOne. GetComponent<SpriteRenderer>().color = col;
		}
		
		if(disableBulletPanel==true)
		{
			if(Input.GetButtonDown("Fire1"))
				{
					panelOne.active=false;
					GetComponent<TextMesh>().text="";
					//Debug.Log("dasd");
				}
		}
	}
}
