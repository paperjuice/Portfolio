using UnityEngine;
using System.Collections;

public class goToLevel : MonoBehaviour {

	public string levelName;


	void OnMouseDown()
	{
		Application.LoadLevel(levelName);
	}
}
