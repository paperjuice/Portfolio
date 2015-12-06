using UnityEngine;
using System.Collections;

public class nextLevelOnClick : MonoBehaviour {

	public string levelName;

	void OnMouseUpAsButton()
	{
		Application.LoadLevel(levelName);
	}
}
