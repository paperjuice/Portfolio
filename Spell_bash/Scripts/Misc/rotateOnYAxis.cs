﻿using UnityEngine;
using System.Collections;

public class rotateOnYAxis : MonoBehaviour {

	public float speed;

	void Update()
	{
		transform.Rotate(Vector3.up * speed * Time.deltaTime);
	}
}
