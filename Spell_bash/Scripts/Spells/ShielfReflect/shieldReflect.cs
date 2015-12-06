using UnityEngine;
using System.Collections;

public class shieldReflect : MonoBehaviour {

	private GameObject[] projectiles;
	
	private float dmgAugmentation;
	
	IEnumerator Start()
	{
		transform.position -= Vector3.up * 7.5f;
	
		while(true)
		{
			projectiles = GameObject.FindGameObjectsWithTag("prop");
			
			yield return new WaitForSeconds(0.01f);	
		}
	}
	
	void OnCollisionEnter(Collision col)
	{
		foreach(GameObject projectile in projectiles)
		{
			if(col.gameObject == projectile)
			{
				dmgAugmentation = Random.Range(2, 6);
			
				projectile.transform.rotation *= Quaternion.AngleAxis(180f, Vector3.up);
				projectile.transform.localScale += new Vector3 (2,2,2);
				if(projectile.GetComponent<fireBall>()!=null)
				projectile.GetComponent<fireBall>().dmg *= dmgAugmentation; 
			}
		}
	}
}
