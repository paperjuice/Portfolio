using UnityEngine;
using System.Collections;

public class resetGame : MonoBehaviour {

	void OnMouseDown()
	{
		PlayerPrefs.SetInt("points", 1);
	}
}
