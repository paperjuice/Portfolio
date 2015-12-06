using UnityEngine;
using System.Collections;

public class dmgTextBehaviour : MonoBehaviour {

	private TextMesh text;
	
	public float ms;
	
	void Awake()
	{
		text = GetComponent<TextMesh>();
	}
	
	void Start()
	{
		transform.rotation = Quaternion.AngleAxis(50, Vector3.right);
		transform.position += new Vector3(0f, 7f, 0f);
	}
	
	void Update()
	{
		Color a = text.color;
		a.a -= Time.deltaTime * 0.5f;
		text.color = a;
		
		transform.position += Vector3.up * ms * Time.deltaTime;
	}
}
