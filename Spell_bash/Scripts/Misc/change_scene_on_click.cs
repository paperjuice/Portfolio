using UnityEngine;
using System.Collections;

public class change_scene_on_click : MonoBehaviour {

	public string level_name;

	void OnMouseDown()
	{
		Application.LoadLevel(level_name);
	}
}
