using UnityEngine;
using System.Collections;

public class highScoreLine : MonoBehaviour {

	void Start()
	{
		if(PlayerPrefs.GetFloat("score")!= 0)
		{
			transform.position = new Vector3(0f,PlayerPrefs.GetFloat("score"), -3f );
		}
	}
}
