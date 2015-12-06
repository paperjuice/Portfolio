using UnityEngine;
using System.Collections;

public class checkTheGameOnGooglePlay : MonoBehaviour {

	private Color render;
	private bool fadeOut;
	
	void Awake()
	{
		render = GetComponent<TextMesh>().color;
	}
	
	IEnumerator Start()
	{
		yield return new WaitForSeconds(3f);
		fadeOut = true;
	}
	
	void Update()
	{
		if(fadeOut == true)
		{
			render.a -= Time.deltaTime;
			GetComponent<TextMesh>().color = render;
			if(render.a <=0 )
			{
				Application.LoadLevel("LoadingScreenToMainMenu");
			}
		}
		
		if(Input.GetButtonDown("Fire1"))
		{
			Application.LoadLevel("LoadingScreenToMainMenu");
		}
	}
}
