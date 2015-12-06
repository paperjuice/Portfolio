using UnityEngine;
using System.Collections;

public class ifAreAnySavedFiles : MonoBehaviour {

	void Awake()
	{
		if(PlayerPrefs.HasKey("asd")==true)
		{
			Debug.Log("exista");
		}
		else
		{
			Debug.Log("nu exista");
		}
	}	
	
}
