using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {

	public string levelName;
	

	IEnumerator Start()
	{
		yield return new WaitForSeconds(0.5f);
		
		Application.LoadLevel(levelName);
	}
}
