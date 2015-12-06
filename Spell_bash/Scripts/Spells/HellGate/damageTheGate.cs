using UnityEngine;
using System.Collections;

public class damageTheGate : MonoBehaviour {

	private GameObject[] gates;
	
	public float dmg;
	
	void Awake()
	{
		gates = GameObject.FindGameObjectsWithTag("hellGate");
	}
	
	void OnCollisionEnter(Collision col)
	{
		foreach(GameObject gate in gates)
		{
			if(col.gameObject == gate)
			{
				gate.GetComponent<hellGate_gate>().health-=dmg;
				Destroy(gameObject);
			}
		}
	}
}
