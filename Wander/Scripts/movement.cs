using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float moveSpeed;
	public float rotateSpeed;
	public GameObject restartPanel;
	public GameObject particle;
	public GameObject halo;
	public GameObject audioOnDeath;
	
	
	private float highestScore;
	private bool movingRight = true;
	private GameObject score;
	private GameObject audio;
	private GameObject ads;
	
	//ads code
	//private string idOfTheAds = "ca-app-pub-7935571317368153/7309333223";
	//private AdMobPlugin adMobPlug;
	//private bool showAd = false;

	void Awake()
	{
		score = GameObject.FindGameObjectWithTag("score");
		audio = GameObject.FindGameObjectWithTag("audio");
		ads = GameObject.FindGameObjectWithTag("ads");
	}
	
	void Start()
	{
		RestartScore();
		
		//adMobPlug.CreateBanner(idOfTheAds, AdMobPlugin.AdSize.SMART_BANNER, true);
		//adMobPlug.RequestAd();
		//adMobPlug = GetComponent<AdMobPlugin>();
		
	}
	
	void Update()
	{
		Switch();
		
		if(moveSpeed <=110f)
		{
			moveSpeed += Time.deltaTime;
		}
		if(rotateSpeed <=160f)
		{
			rotateSpeed += Time.deltaTime ;
		}
		
		
		//ads off
		

		if(movingRight == true)
		{
			transform.position += transform.up * moveSpeed * Time.deltaTime;
			transform.Rotate( transform.forward* rotateSpeed * Time.deltaTime);
		}
		else
		{
			transform.position += transform.up * moveSpeed * Time.deltaTime;
			transform.Rotate( transform.forward* -rotateSpeed * Time.deltaTime);
		}
	}
	
	void Switch()
	{
		
	
		if(Input.GetButton("Fire1"))
		{
			movingRight = false;
		}
		else
		{
			movingRight = true;
		}
	}
	
	void OnCollisionEnter2D()
	{
		enabled=false;
		GetComponent<CircleCollider2D>().enabled = false;
		restartPanel.active=true;
		GetComponent<SpriteRenderer>().enabled = false;
		Instantiate(particle, transform.position, transform.rotation);
		Instantiate(audioOnDeath, transform.position, transform.rotation);
		Destroy(halo.gameObject);
		audio.GetComponent<audioOnDeath>().lowPitch = true;
		ads.GetComponent<ads>().showAd = true;
		highestScore = score.GetComponent<score>().scoreText;
		
		if(highestScore >= PlayerPrefs.GetFloat("score"))
		{
			PlayerPrefs.SetFloat("score", score.GetComponent<score>().scoreText);
		}
		
		//show ads
		//showAd=true;
		
		
	}	
	
	void RestartScore()
	{
		if(resetScoreToZero.reset == 1)
		{
			PlayerPrefs.SetFloat("score", 0f);
			resetScoreToZero.reset=0;
		}
	}
	
	
}
